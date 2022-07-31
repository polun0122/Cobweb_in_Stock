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
            tbBuyInterval.Text = "1";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
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
            int maxInvestMoney;
            if (! int.TryParse(tbMaxInvestMoney.Text, out maxInvestMoney))
            {
                MessageBox.Show("錯誤：最大投資金額須為正整數");
                return;
            }
            float buyInterval;
            if (!float.TryParse(tbBuyInterval.Text, out buyInterval))
            {
                MessageBox.Show("錯誤：買進區間須為正數");
                return;
            }
            float sellInterval;
            if (!float.TryParse(tbSellInterval.Text, out sellInterval))
            {
                MessageBox.Show("錯誤：賣出區間須為正數");
                return;
            }
            int expectAmount;
            if (!int.TryParse(tbExpectAmount.Text, out expectAmount))
            {
                MessageBox.Show("錯誤：單次操作股數須為正整數");
                return;
            }
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
            string strategy = String.Format(template, tbBuyInterval.Text, tbExpectAmount.Text, tbSellInterval.Text, tbExpectAmount.Text);
            tbStrategyDetail.Text = strategy;
        }
    }
}
