using System;
using System.Windows.Forms;

namespace Cobweb_in_Stock
{
    public partial class Form2 : Form
    {
        ManagedExcelApp excelApp = new ManagedExcelApp();
        string filePath = "";

        public Form2()
        {
            InitializeComponent();
            dateDealDate.Value = DateTime.Now;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            excelApp.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            excelApp.CreateEmptyFile();
            excelApp.worksheet.Name = tbStockName.Text;
            ExcelCell cell = new ExcelCell(excelApp.worksheet);
            cell.initialWorksheet();
            string stockName = tbStockName.Text;
            string stockNumber = tbStockNumber.Text;
            int maxInvestMoney = (int)nbMaxInvestMoney.Value;
            float buyInterval = (float)nbBuyInterval.Value;
            float sellInterval = (float)nbSellInterval.Value;
            int expectAmount = (int)nbExpectAmount.Value;
            cell.basicDataWrite(stockName, stockNumber, maxInvestMoney, buyInterval, sellInterval, expectAmount);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = stockName + "蛛網";
            saveFileDialog.Title = "儲存檔案";
            saveFileDialog.Filter = "工作表 |*.xlsx";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                excelApp.SaveAs(filePath);
                MessageBox.Show("儲存成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("錯誤：請設定儲存路徑");
            }
        }

        private void updateStrategy(object sender, EventArgs e)
        {
            string template = "跌 {0} 元買 {1} 股，買進後漲 {2} 元賣 {3} 股";
            string strategy = String.Format(template, nbBuyInterval.Text, nbExpectAmount.Text, nbSellInterval.Text, nbExpectAmount.Text);
            tbStrategyDetail.Text = strategy;
        }
    }
}
