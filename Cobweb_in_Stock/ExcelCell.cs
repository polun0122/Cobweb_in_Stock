using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace Cobweb_in_Stock
{
    internal class Cell
    {
        public enum Align
        {
            Right, Left, Center
        }

        Excel.Worksheet worksheet;
        int row;
        string column_str;
        int column_int;
        string index_str;

        public Cell(Excel.Worksheet worksheet, int row, string column)
        {
            this.worksheet = worksheet;
            this.row = row;
            this.column_str = column;
            this.column_int = 0;
            foreach(char c in column)
            {
                this.column_int += (int)c - 'A' + 1;
            }
            this.index_str = column + row;
        }

        public string getValue()
        {
            return worksheet.Cells[row, column_int].Text;
        }

        public string getIndex()
        {
            return index_str;
        }

        public void writeTitle(string title, bool addBorder)
        {
            //用於最左側(基本資料表格)儲存格
            worksheet.Cells[row, column_int - 1] = title;
            if (addBorder)
                worksheet.Cells[row, column_int - 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        public void writeValue(string value)
        {
            //用於一般儲存格
            worksheet.Cells[row, column_int] = value;
        }

        public void setAlign(Align align)
        {
            /* 設定儲存格對齊方式 */
            if (align == Align.Right)
                worksheet.Cells[row, column_int].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            else if (align == Align.Left)
                worksheet.Cells[row, column_int].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            else if (align == Align.Center)
                worksheet.Cells[row, column_int].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }

        public void addBorder()
        {
            worksheet.Cells[row, column_int].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        public void setColumnWidth(float widthInDot)
        {
            worksheet.Cells[row, column_int].ColumnWidth = widthInDot;
        }

        public void setColor(Color color)
        {
            worksheet.Cells[row, column_int].Interior.Color = ColorTranslator.ToOle(color);
        }
    }

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

        public void initialWorksheet()
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
            obtainedProfit.writeValue("=SUMIF(" + col_balance + ":" + col_balance + ",\" > 0\")");
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
            buyDataWrite(labelStringBuy, rowDataStart - 1);
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
            buyDataWidthSet();
            sellDataWidthSet();
            //儲存格高度
            worksheet.Range["A1:A2"].RowHeight = 31.50;
        }

        public void basicDataWrite(string name, string number, int maxInvestMoney, float buyInterval, float sellInterval, int expectAmount)
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

        public void buyDataWrite(string[] data, int row)
        {
            /* 買進資料輸入 */
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
                worksheet.Cells[row, col_balance] = "=" + col_sellTotalPrice + row + "-" + col_buyTotalPrice + row;
        }

        public void sellDataWrite(string[] data, int row)
        {
            /* 賣出資料輸入 */
            // 賣出單價
            worksheet.Cells[row, col_sellUnitPrice] = data[0];
            // 賣出數量
            worksheet.Cells[row, col_sellAmount] = data[1];
            // 成交日期
            worksheet.Cells[row, col_sellDate] = data[2];
            // 賣出收益
            worksheet.Cells[row, col_sellTotalPrice] = data[3];
        }

        public void buyDataWidthSet()
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

        public void sellDataWidthSet()
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
    }
}
