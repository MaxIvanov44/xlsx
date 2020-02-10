using ClosedXML.Excel;
using GemBox.Spreadsheet;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class Excel
    {
        public async Task Export(DataTable table)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("DataTable to Sheet");

            

            worksheet.Cells[0, 0].Value = "DataTable insert example:";

            // Insert DataTable to an Excel worksheet.
            worksheet.InsertDataTable(table,
                new InsertDataTableOptions()
                {
                    ColumnHeaders = true,
                    StartRow = 1
                });

            workbook.Save("~/wwwroot/reports/DataTable to Sheet.xlsx");
        }
    }
}