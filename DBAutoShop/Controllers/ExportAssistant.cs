using System;
using System.Configuration;
using System.Web;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Diagnostics;
using Microsoft.Office.Interop;
using Microsoft.Office.Tools;

namespace DBAutoShop.Controllers
{
    class ExportAssistant
    {
        public ExportAssistant()
        {
        }

        public void ToXLS(DataGridView dGV, string fileName)
        {

            Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();

            ExcelApp.Application.Workbooks.Add(Type.Missing);



            // Change properties of the Workbook 

            ExcelApp.Columns.ColumnWidth = 20;



            // Storing header part in Excel

            for (int i = 1; i < dGV.Columns.Count + 1; i++)
            {

                ExcelApp.Cells[1, i] = dGV.Columns[i - 1].HeaderText;

            }



            // Storing Each row and column value to excel sheet

            for (int i = 0; i < dGV.Rows.Count; i++)
            {

                for (int j = 0; j < dGV.Columns.Count; j++)
                {

                    ExcelApp.Cells[i + 2, j + 1] = dGV.Rows[i].Cells[j].Value.ToString();

                }

            }



            ExcelApp.ActiveWorkbook.SaveCopyAs(fileName);

            ExcelApp.ActiveWorkbook.Saved = true;

            ExcelApp.Quit();
        }

    }
}
