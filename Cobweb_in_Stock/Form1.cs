using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cobweb_in_Stock
{
    public partial class Form1 : Form
    {
        string filePath;
        string Mode;
        ManagedExcelApp excelApp = new ManagedExcelApp();
        ExcelCell excelCell = null;

        Stock stock = null;

        public Form1()
        {
            InitializeComponent();
            comboBoxMode.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPriceUpdate();
        }

        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "選擇檔案";
            openFileDialog.Filter = "工作表 |*.xlsx";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBoxFilePath.Text = filePath;
                if (File.Exists(filePath))
                {
                    OpenFile();
                }
            }
            else
            {
                textBoxFileStatus.Text = "找不到檔案，請重新選擇";
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (excelApp.worksheet != null)
            {
                int rowCount = excelCell.rowDataMax;
                
                if (Mode == "買進")
                {
                    string[] data = {
                    //目標單價
                        boxTargetUnitPrice.Value.ToString(),
                    //單價
                        boxUnitPrice.Value.ToString(),
                    //數量
                        boxAmount.Value.ToString(),
                    //成交日期
                        dateTimePicker.Value.ToString("yyyy/MM/dd"),
                    //總成本
                        boxTotalPrice.Value.ToString(),
                    };
                    excelCell.buyDataWrite(data, rowCount);
                    excelCell.rowDataMax += 1;
                }
                else
                {
                    float targetBuyPrice = (float)boxTargetUnitPrice.Value - stock.getSellInterval();
                    bool isFound = false;
                    string[] data = {
                        //單價
                            boxUnitPrice.Value.ToString(),
                        //數量
                            boxAmount.Value.ToString(),
                        //成交日期
                            dateTimePicker.Value.ToString("yyyy/MM/dd"),
                        //總收益
                            boxTotalPrice.Value.ToString()
                        };
                    for (int i = excelCell.rowDataStart; i < rowCount; i++)
                    {
                        if (excelCell.getTargetPriceValue(i) == targetBuyPrice.ToString() && excelCell.getSellUnitPriceValue(i) == "")
                        {
                            excelCell.sellDataWrite(data, i);
                            isFound = true;

                            //本次獲利讀取
                            MessageBox.Show("本次獲利：" + excelCell.getBalance(i) + "元");
                        }
                    }
                    if (!isFound)
                    {
                        excelCell.sellDataWrite(data, rowCount);
                        excelCell.rowDataMax += 1;

                        //本次獲利讀取 TODO: 下一行注意
                        MessageBox.Show("(賣庫存需手動修正) 本次獲利：" + excelCell.getBalance(rowCount) + "元");
                    }
                }
                //存檔
                excelApp.Save();
                MessageBox.Show("儲存成功");
                ProfitStockDateUpdate();
                NextOperatePriceUpdate();
                totalPriceUpdate();
            }
            else
            {
                MessageBox.Show("請先選擇Excel檔案");
            }
        }

        private void boxTargetUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            boxUnitPrice.Value = boxTargetUnitPrice.Value;
            boxPriceIcrementlUpdate(boxTargetUnitPrice);
        }

        private void boxUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            totalPriceUpdate();
            boxPriceIcrementlUpdate(boxUnitPrice);
        }

        private void boxPriceIcrementlUpdate(NumericUpDown numericBox)
        {
            if (stock != null)
            {
                if (!stock.isSpecialStock())
                {
                    if (numericBox.Value < 10)
                        numericBox.Increment = (decimal)0.01;
                    else if (numericBox.Value < 50)
                        numericBox.Increment = (decimal)0.05;
                    else if (numericBox.Value < 100)
                        numericBox.Increment = (decimal)0.1;
                    else if (numericBox.Value < 500)
                        numericBox.Increment = (decimal)0.5;
                    else if (numericBox.Value < 1000)
                        numericBox.Increment = (decimal)1;
                    else
                        numericBox.Increment = (decimal)5;
                }
                else
                {
                    if (numericBox.Value < 50)
                        numericBox.Increment = (decimal)0.01;
                    else
                        numericBox.Increment = (decimal)0.05;
                }
            }
        }

        private void boxAmount_ValueChanged(object sender, EventArgs e)
        {
            totalPriceUpdate();
        }

        private void totalPriceUpdate()
        {
            Mode = comboBoxMode.SelectedItem.ToString();
            if (stock != null)
                stock.updateTransactionPrice(Mode, (float)boxUnitPrice.Value, (int)boxAmount.Value);
            updateUi();
        }

        private void updateUi()
        {
            Mode = comboBoxMode.SelectedItem.ToString();
            if (Mode == "買進")
            {
                buttonSend.BackColor = Color.Red;
                buttonSend.ForeColor = Color.White;
                if (stock != null)
                    boxTargetUnitPrice.Value = (decimal)stock.getNextBuyPrice();
            }
            else
            {
                buttonSend.BackColor = Color.Green;
                buttonSend.ForeColor = Color.White;
                if (stock != null)
                    boxTargetUnitPrice.Value = (decimal)stock.getNextSellPrice();
            }
            if (stock != null)
            {
                textBoxFee.Text = Math.Round(stock.getFee(), 2).ToString("#0.00");
                textBoxTax.Text = Math.Round(stock.getTax(), 2).ToString("#0.00");
                boxTotalPrice.Value = (decimal)stock.getDealPrice();
            }
        }

        private void OpenFile()
        {
            textBoxFileStatus.Text = "載入中...";
            if (excelApp.Open(filePath) == -1)
            {
                textBoxFileStatus.Text = "檔案被使用中";
            }
            else
            {
                textBoxFileStatus.Text = "已載入";
                excelCell = new ExcelCell(excelApp.worksheet);
                string stockName = excelCell.stockName.getValue();
                string stockNumber = excelCell.stockNumber.getValue();
                float buyInterval;
                if (!float.TryParse(excelCell.buyInterval.getValue(), out buyInterval))
                {
                    MessageBox.Show("錯誤，買進區間需為數字，請檢查Excel檔案");
                    return;
                }
                float sellInterval;
                if (!float.TryParse(excelCell.sellInterval.getValue(), out sellInterval))
                {
                    MessageBox.Show("錯誤，賣出區間需為數字，請檢查Excel檔案");
                    return;
                }
                int expectAmount;
                if (!int.TryParse(excelCell.expectSellAmount.getValue(), out expectAmount))
                {
                    MessageBox.Show("錯誤，每次操作數量需為正整數，請檢查Excel檔案");
                    return;
                }
                stock = new Stock(stockName, stockNumber, buyInterval, sellInterval, expectAmount, 300, 250);

                boxAmount.Value = decimal.Parse(excelCell.expectBuyAmount.getValue());
                ProfitStockDateUpdate();
                NextOperatePriceUpdate();
                totalPriceUpdate();
            }
        }

        private void ProfitStockDateUpdate()
        {
            /* 抓取EXCEL表格更新已實現獲利、庫存股數、最後更新日期 */
            if (excelCell != null)
            {
                tbObtainedProfit.Text = excelCell.obtainedProfit.getValue();
                tbReserveAmount.Text = excelCell.reserveAmount.getValue();
                tbLastUpdate.Text = excelCell.lastUpdateDate.getValue();
            }
        }

        private void NextOperatePriceUpdate()
        {
            /* 更新下次需操作股價 */
            if (excelApp.worksheet != null && excelCell != null)
            {
                float minPriceInStock = float.MaxValue;
                for (int i = excelCell.rowDataStart; i <= excelCell.rowDataMax; i++)
                {
                    float buyPriceInCell;
                    if (float.TryParse(excelCell.getTargetPriceValue(i), out buyPriceInCell))
                    {
                        if (buyPriceInCell < minPriceInStock && excelCell.getSellUnitPriceValue(i) == "")
                        {
                            minPriceInStock = buyPriceInCell;
                        }
                    }
                }
                if (stock != null)
                    stock.setNextPrice(minPriceInStock - stock.getBuyInterval(), minPriceInStock + stock.getSellInterval());
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            textBoxFileStatus.Text = "建立中...";
            btnCreateFile.Enabled = false;
            Form2 formNewStock = new Form2();
            formNewStock.Show();
            formNewStock.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelApp.Close();
        }
    }
}
