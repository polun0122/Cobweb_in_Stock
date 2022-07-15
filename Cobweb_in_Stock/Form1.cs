using System;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace Cobweb_in_Stock
{
    public partial class Form1 : Form
    {
        string filePath = Environment.CurrentDirectory + "台達蛛網.xlsx";
        string Mode;
        ManagedExcelApp excelApp = new ManagedExcelApp();
        
        Stock stock = new Stock("台達電", 275, 200, (float)2.5, 5);

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
                int rowCount = excelApp.worksheet.UsedRange.Cells.Rows.Count;
                
                if (Mode == "買進")
                {
                    //目標單價
                    excelApp.worksheet.Cells[rowCount + 1, "A"] = boxTargetUnitPrice.Value.ToString();
                    //單價
                    excelApp.worksheet.Cells[rowCount + 1, "B"] = boxUnitPrice.Value.ToString();
                    //數量
                    excelApp.worksheet.Cells[rowCount + 1, "C"] = boxAmount.Value.ToString();
                    //成交日期
                    excelApp.worksheet.Cells[rowCount + 1, "D"] = dateTimePicker.Value.ToString("yyyy/MM/dd");
                    //總成本
                    excelApp.worksheet.Cells[rowCount + 1, "E"] = boxTotalPrice.Value.ToString();
                    //損益
                    excelApp.worksheet.Cells[rowCount + 1, "J"] = "=I" + (rowCount + 1) + "-E" + (rowCount + 1);
                }
                else
                {
                    float targetBuyPrice = (float)boxTargetUnitPrice.Value - 5;
                    bool isFound = false;
                    for (int i = 3; i <= rowCount; i++)
                    {
                        Excel.Range targetPriceCell = (Excel.Range)excelApp.worksheet.Cells[i, "A"];
                        Excel.Range soldPriceCell = (Excel.Range)excelApp.worksheet.Cells[i, "F"];

                        if (targetPriceCell.Value.ToString() == targetBuyPrice.ToString() && soldPriceCell.Value2 == null)
                        {
                            //單價
                            excelApp.worksheet.Cells[i, "F"] = boxUnitPrice.Value.ToString();
                            //數量
                            excelApp.worksheet.Cells[i, "G"] = boxAmount.Value.ToString();
                            //成交日期
                            excelApp.worksheet.Cells[i, "H"] = dateTimePicker.Value.ToString("yyyy/MM/dd");
                            //總收益
                            excelApp.worksheet.Cells[i, "I"] = boxTotalPrice.Value.ToString();
                            isFound = true;

                            //本次獲利讀取
                            Excel.Range thisTimeProfitCell = (Excel.Range)excelApp.worksheet.Cells[i, "J"];
                            MessageBox.Show("本次獲利：" + thisTimeProfitCell.Text + "元");
                        }
                    }
                    if (!isFound)
                    {
                        //單價
                        excelApp.worksheet.Cells[rowCount + 1, "F"] = boxUnitPrice.Value.ToString();
                        //數量
                        excelApp.worksheet.Cells[rowCount + 1, "G"] = boxAmount.Value.ToString();
                        //成交日期
                        excelApp.worksheet.Cells[rowCount + 1, "H"] = dateTimePicker.Value.ToString("yyyy/MM/dd");
                        //總收益
                        excelApp.worksheet.Cells[rowCount + 1, "I"] = boxTotalPrice.Value.ToString();
                        //損益
                        excelApp.worksheet.Cells[rowCount + 1, "J"] = "=I" + (rowCount + 1) + "-E" + (rowCount + 1);

                        //本次獲利讀取
                        Excel.Range thisTimeProfitCell = (Excel.Range)excelApp.worksheet.Cells[rowCount + 1, "J"];
                        MessageBox.Show("(賣庫存需手動修正) 本次獲利：" + thisTimeProfitCell.Text + "元");
                    }
                }
                //存檔
                excelApp.Save();
                MessageBox.Show("儲存成功");
                ProfitStockDateUpdate();
                NextOperatePriceUpdate();
            }
            else
            {
                MessageBox.Show("請先選擇Excel檔案");
            }
        }

        private void boxTargetUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            boxUnitPrice.Value = boxTargetUnitPrice.Value;
        }

        private void boxUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            totalPriceUpdate();
        }

        private void boxAmount_ValueChanged(object sender, EventArgs e)
        {
            totalPriceUpdate();
        }

        private void totalPriceUpdate()
        {
            Mode = comboBoxMode.SelectedItem.ToString();
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
                boxTargetUnitPrice.Value = (decimal)stock.getNextBuyPrice();
            }
            else
            {
                buttonSend.BackColor = Color.Green;
                buttonSend.ForeColor = Color.White;
                boxTargetUnitPrice.Value = (decimal)stock.getNextSellPrice();
            }
            textBoxFee.Text = Math.Round(stock.getFee(), 2).ToString("#0.00");
            textBoxTax.Text = Math.Round(stock.getTax(), 2).ToString("#0.00");
            boxTotalPrice.Value = (decimal)stock.getDealPrice();
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
                ProfitStockDateUpdate();
                NextOperatePriceUpdate();
            }
        }

        private void ProfitStockDateUpdate()
        {
            /* 抓取EXCEL表格更新已實現獲利、庫存股數、最後更新日期 */
            Excel.Range profitCell = (Excel.Range)excelApp.worksheet.Cells[5, "N"];
            textBoxObtainedProfit.Text = profitCell.Text;
            Excel.Range stockCell = (Excel.Range)excelApp.worksheet.Cells[6, "N"];
            textBoxStock.Text = stockCell.Text;
            Excel.Range lastUpdateCell = (Excel.Range)excelApp.worksheet.Cells[7, "N"];
            textBoxLastUpdate.Text = lastUpdateCell.Text;
        }

        private void NextOperatePriceUpdate()
        {
            /* 更新下次需操作股價 */
            if (excelApp.worksheet != null)
            {
                int rowCount = excelApp.worksheet.UsedRange.Cells.Rows.Count;
                float minPriceInStock = float.MaxValue;
                for (int i = 3; i <= rowCount; i++)
                {
                    Excel.Range targetPriceCell = (Excel.Range)excelApp.worksheet.Cells[i, "A"];
                    Excel.Range soldPriceCell = (Excel.Range)excelApp.worksheet.Cells[i, "F"];
                    float buyPriceInCell;
                    if (float.TryParse(targetPriceCell.Value.ToString(), out buyPriceInCell))
                    {
                        if (buyPriceInCell < minPriceInStock && soldPriceCell.Value2 == null)
                        {
                            minPriceInStock = buyPriceInCell;
                        }
                    }
                }
                stock.setNextPrice((float)(minPriceInStock - 2.5), (float)(minPriceInStock + 5));
                //totalPriceUpdate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelApp.Close();
        }

    }
}
