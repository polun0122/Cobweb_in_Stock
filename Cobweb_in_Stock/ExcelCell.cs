using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace Cobweb_in_Stock
{
    internal class ExcelCell
    {
        Excel.Worksheet worksheet;

        public Cell stockNumber;
        public Cell stockName;
        public Cell maxInvestMoney;
        public Cell investedMoney;
        public Cell remainMoney;
        public Cell obtainedProfit;
        public Cell reserveAmount;
        public Cell lastUpdateDate;

        public Cell buyInterval;
        public Cell sellInterval;
        public Cell expectBuyAmount;
        public Cell expectSellAmount;

        private Cell[] labelStrategy = new Cell[6];
        //private Cell labelBuy = new Cell(2, "D");
        //private Cell labelSell = new Cell(2, "I");

        private string col_targetPrice = "D";
        private string col_buyUnitPrice = "E";
        private string col_buyAmount = "F";
        private string col_buyDate = "G";
        private string col_buyTotalPrice = "H";
        private string col_sellUnitPrice = "I";
        private string col_sellAmount = "J";
        private string col_sellDate = "K";
        private string col_sellTotalPrice = "L";
        private string col_balance = "M";
        public int rowDataStart = 3;
        public int rowDataMax;

        public ExcelCell(Excel.Worksheet worksheet)
        {
            this.worksheet = worksheet;
            rowDataMax = rowDataStart;
            while (worksheet.Cells[rowDataMax, col_targetPrice].Text != "")
                rowDataMax++;
            stockNumber = new Cell(worksheet, 1, "B");
            stockName = new Cell(worksheet, 2, "B");
            maxInvestMoney = new Cell(worksheet, 3, "B");
            investedMoney = new Cell(worksheet, 4, "B");
            remainMoney = new Cell(worksheet, 5, "B");
            obtainedProfit = new Cell(worksheet, 6, "B");
            reserveAmount = new Cell(worksheet, 7, "B");
            lastUpdateDate = new Cell(worksheet, 8, "B");

            buyInterval = new Cell(worksheet, 1, "E");
            sellInterval = new Cell(worksheet, 1, "J");
            expectBuyAmount = new Cell(worksheet, 1, "G");
            expectSellAmount = new Cell(worksheet, 1, "L");

            labelStrategy[0] = new Cell(worksheet, 1, "D");
            labelStrategy[1] = new Cell(worksheet, 1, "F");
            labelStrategy[2] = new Cell(worksheet, 1, "H");
            labelStrategy[3] = new Cell(worksheet, 1, "I");
            labelStrategy[4] = new Cell(worksheet, 1, "K");
            labelStrategy[5] = new Cell(worksheet, 1, "M");
        }

        public string getTargetPriceValue(int row)
        {
            return worksheet.Cells[row, col_targetPrice].Text;
        } 

        public string getBalance(int row)
        {
            return worksheet.Cells[row, col_balance].Text;
        }

        public string getSellUnitPriceValue(int row)
        {
            return worksheet.Cells[row, col_sellUnitPrice].Text;
        }

        public void InitialWorksheet()
        {
            stockNumber.writeTitle("股票代碼", true);
            stockNumber.setAlign(Cell.Align.Center);
            stockNumber.addBorder();
            stockName.writeTitle("股票名稱", true);
            stockName.setAlign(Cell.Align.Center);
            stockName.addBorder();
            maxInvestMoney.writeTitle("預計總投入金額", true);
            maxInvestMoney.addBorder();
            investedMoney.writeTitle("目前投入金額", true);
            investedMoney.writeValue("=SUM(" + col_balance + "$" + rowDataStart + ":" + col_balance + "$1048576)*-1");
            investedMoney.addBorder();
            remainMoney.writeTitle("剩餘可投入金額", true);
            remainMoney.writeValue("=" + maxInvestMoney.getIndex() + "-" + investedMoney.getIndex());
            remainMoney.addBorder();
            obtainedProfit.writeTitle("已實現獲利", true);
            obtainedProfit.writeValue("=SUMIF(" + col_balance + ":" + col_balance + ",\">0\")");
            obtainedProfit.addBorder();
            reserveAmount.writeTitle("庫存股票", true);
            reserveAmount.writeValue("=SUM(" + col_buyAmount + "$" + rowDataStart + ":" + col_buyAmount + "$1048576)-SUM(" + col_sellAmount + "$" + rowDataStart + ":" + col_sellAmount + "$1048576)");
            reserveAmount.addBorder();
            lastUpdateDate.writeTitle("最後更新日", true);
            lastUpdateDate.writeValue("=MAX(MAX(" + col_buyDate + ":" + col_buyDate + "),MAX(" + col_sellDate + ":" + col_sellDate + "))");
            lastUpdateDate.addBorder();

            labelStrategy[0].writeValue("跌");
            labelStrategy[1].writeValue("元，買");
            labelStrategy[2].writeValue("股。");
            labelStrategy[3].writeValue("買進後漲");
            labelStrategy[4].writeValue("元，賣");
            labelStrategy[5].writeValue("股。");
            foreach (var cell in labelStrategy)
            {
                cell.setAlign(Cell.Align.Center);
            }
            //labelBuy.writeValue(worksheet, "買進");
            //labelSell.writeValue(worksheet, "賣出");
            string[] labelStringBuy = { "目標單價", "買進單價", "買進數量", "成交日期", "買進成本", "損益" };
            BuyDataWrite(labelStringBuy);
            string[] labelStringSell = { "賣出單價", "賣出數量", "成交日期", "賣出收益" };
            sellDataWrite(labelStringSell, rowDataStart - 1);
            /* 新增明細區框線 */
            worksheet.Range[col_targetPrice + ":" + col_balance].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            /* 新增策略區框線 */
            worksheet.Range[col_targetPrice + "1:" + col_balance + "1"].Borders.LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            worksheet.Range[col_targetPrice + "1:" + col_balance + "1"].BorderAround2();
            /* 設定顏色 */
            Color customBlue = Color.FromArgb(221, 235, 247);
            Color customRed = Color.FromArgb(255, 199, 206);
            Color customGreen = Color.FromArgb(198, 239, 206);
            worksheet.Range[col_targetPrice + ":" + col_buyTotalPrice].Interior.Color = ColorTranslator.ToOle(customRed);
            worksheet.Range[col_sellUnitPrice + ":" + col_sellTotalPrice].Interior.Color = ColorTranslator.ToOle(customGreen);
            worksheet.Range["D1:M1"].Interior.Color = ColorTranslator.ToOle(customBlue);
            //儲存格寬度
            worksheet.Range["A1:B1"].ColumnWidth = 15.50;
            worksheet.Range["C:C"].ColumnWidth = 2;
            BuyDataWidthSet();
            SellDataWidthSet();
            //儲存格高度
            worksheet.Range["A1:A2"].RowHeight = 31.50;
        }

        public void BuyDataWidthSet()
        {
            // 目標單價
            worksheet.Cells[rowDataStart, col_targetPrice].ColumnWidth = 8.88;
            // 買進單價
            worksheet.Cells[rowDataStart, col_buyUnitPrice].ColumnWidth = 8.88;
            // 買進數量
            worksheet.Cells[rowDataStart, col_buyAmount].ColumnWidth = 8.88;
            // 成交日期
            worksheet.Cells[rowDataStart, col_buyDate].ColumnWidth = 9.88;
            // 買進成本
            worksheet.Cells[rowDataStart, col_buyTotalPrice].ColumnWidth = 8.88;
            // 損益
            worksheet.Cells[rowDataStart, col_balance].ColumnWidth = 8.88;
        }

        public void SellDataWidthSet()
        {
            // 賣出單價
            worksheet.Cells[rowDataStart, col_sellUnitPrice].ColumnWidth = 8.88;
            // 賣出數量
            worksheet.Cells[rowDataStart, col_sellAmount].ColumnWidth = 8.88;
            // 成交日期
            worksheet.Cells[rowDataStart, col_sellDate].ColumnWidth = 9.88;
            // 賣出收益
            worksheet.Cells[rowDataStart, col_sellTotalPrice].ColumnWidth = 8.88;
        }

        public void BasicDataWrite(string name, string number, int maxInvestMoney, float buyInterval, float sellInterval, int expectAmount)
        {
            this.stockName.writeValue(name);
            this.stockNumber.writeValue(number);
            this.maxInvestMoney.writeValue(maxInvestMoney.ToString());
            this.buyInterval.writeValue(buyInterval.ToString());
            this.buyInterval.setAlign(Cell.Align.Center);
            this.sellInterval.writeValue(sellInterval.ToString());
            this.sellInterval.setAlign(Cell.Align.Center);
            this.expectBuyAmount.writeValue(expectAmount.ToString());
            this.expectBuyAmount.setAlign(Cell.Align.Center);
            this.expectSellAmount.writeValue(expectAmount.ToString());
            this.expectSellAmount.setAlign(Cell.Align.Center);
        }

        public void BuyDataWrite(string[] data)
        {
            /* 買進資料輸入 */
            int row;
            // 損益
            if (data.Length > 5)
                row = rowDataStart - 1;
            else
                row = rowDataMax;

            // 目標單價
            worksheet.Cells[row, col_targetPrice] = data[0];
            // 買進單價
            worksheet.Cells[row, col_buyUnitPrice] = data[1];
            // 買進數量
            worksheet.Cells[row, col_buyAmount] = data[2];
            // 成交日期
            worksheet.Cells[row, col_buyDate] = data[3];
            // 買進成本
            worksheet.Cells[row, col_buyTotalPrice] = data[4];
            // 損益
            if (data.Length > 5)
                worksheet.Cells[row, col_balance] = data[5];
            else
            {
                worksheet.Cells[row, col_balance] = "=" + col_sellTotalPrice + rowDataMax + "-" + col_buyTotalPrice + rowDataMax;
                rowDataMax++;
            }
        }

        public string SellDataWrite(string[] data)
        {
            float targetBuyPrice = float.Parse(data[0]) - float.Parse(sellInterval.getValue());

            for (int i = rowDataStart; i < rowDataMax; i++)
            {
                if (getTargetPriceValue(i) == targetBuyPrice.ToString() && getSellUnitPriceValue(i) == "")
                {
                    sellDataWrite(data, i);
                    //本次獲利讀取
                    return "本次獲利：" + getBalance(i) + "元";
                }
            }
            return "Error: 查無買進資料寫入失敗，請確認後再試一次";
        }
        private void sellDataWrite(string[] data, int row)
        {
            /* 賣出資料寫入Excel */
            // 賣出單價
            worksheet.Cells[row, col_sellUnitPrice] = data[0];
            // 賣出數量
            worksheet.Cells[row, col_sellAmount] = data[1];
            // 成交日期
            worksheet.Cells[row, col_sellDate] = data[2];
            // 賣出收益
            worksheet.Cells[row, col_sellTotalPrice] = data[3];
        }

        public void SetReserveInfo(float buyUnitPrice, int amount, int totalCost, string dealDate)
        {
            float buyInterval_f = float.Parse(buyInterval.getValue());
            int expextAmount_i = int.Parse(expectBuyAmount.getValue());
            int number = amount / expextAmount_i;
            int unitCost = totalCost / number;
            int restCost = totalCost % number;

            for (int i = 0; i < number; i++)
            {
                int unitCostTemp;
                if (restCost > 0)
                {
                    unitCostTemp = unitCost + 1;
                    restCost--;
                }
                else
                {
                    unitCostTemp = unitCost;
                }
                float unitPrice = buyUnitPrice + buyInterval_f * (number - i - 1);
                string[] data = {
                    //目標單價
                        unitPrice.ToString(),
                    //單價
                        buyUnitPrice.ToString(),
                    //數量
                        expextAmount_i.ToString(),
                    //成交日期
                        dealDate,
                    //總成本
                        unitCostTemp.ToString(),
                    };
                BuyDataWrite(data);
            }
        }
    }
}
