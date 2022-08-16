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
            foreach (char c in column)
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
}
