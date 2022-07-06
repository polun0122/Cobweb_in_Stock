using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cobweb_in_Stock
{
    class ManagedExcelApp : IDisposable
    {
        dynamic excelApp = null;
        Excel.Workbook workbook = null;
        public Excel.Worksheet worksheet = null;

        public ManagedExcelApp()
        {
            excelApp = new Excel.Application();
        }
        public int Open(string path)
        {
            try
            {
                workbook = excelApp.Workbooks.Open(path);
                worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
                //excelApp.Visible = true;
                return 1;
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                return -1;
            }
        }
        public void Save()
        {
            workbook.Save();
        }

        public void Close()
        {
            worksheet = null;
            if (workbook != null)
                workbook.Close();
            workbook = null;
            if (excelApp != null)
                excelApp.Quit();
            excelApp = null;
        }

        #region IDisposable Support
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                try
                {
                    //if (workbook == null)
                    //    return;
                    //Console.WriteLine("關閉workbook;");
                    //workbook.Close();

                    if (excelApp == null)
                        return;

                    Console.WriteLine("執行Excel.Quit();");
                    excelApp.Quit();

                    Console.WriteLine("釋放COM物件");
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                }
                catch (Exception)
                {
                    System.Environment.Exit(System.Environment.ExitCode);

                }
                finally
                {
                    Console.WriteLine("進行GC回收");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MangedExcelApp()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
