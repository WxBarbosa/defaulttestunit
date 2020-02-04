using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Drawing;
using System.Reflection;

namespace DefaultTestUnit.Domain.Helpers
{
    public class ExcelHelper 
    {
        private ExcelPackage package;
        private ExcelWorksheet worksheet;
        private ExcelWorkbook workbook;

        #region Constructs

        public ExcelHelper(string path)
        {
            FileInfo fileInfo = new FileInfo(path);

            if (!fileInfo.Exists)
            {
                throw new Exception("File " + path + " Does not exist.");
            }

            this.package = new ExcelPackage(fileInfo);
            this.workbook = this.package.Workbook;
        }

        public ExcelHelper(MemoryStream streamFile)
        {
            this.package = new ExcelPackage(streamFile);
            this.workbook = this.package.Workbook;
        }

        public ExcelHelper(FileInfo fileInfo)
        {
            this.package = new ExcelPackage(fileInfo);
            this.workbook = this.package.Workbook;
        }

        public ExcelHelper()
        {
            this.package = new ExcelPackage();
            this.workbook = this.package.Workbook;
            this.SetProperties("LSL Transportes","Planilha teste", "Conteúdo");
        }
        #endregion

        private void SetProperties(string author,string title, string subject)
        {
            this.workbook.Properties.Author = author;
            this.workbook.Properties.Title = title;
            this.workbook.Properties.Subject = subject;
            this.workbook.Properties.Created = DateTime.Now;
        }
        
        #region Styles Cells
        private void DrawnFontBold(ExcelRange cell)
        {
            cell.Style.Font.Bold = true;
        }

        private void DrawnBackgroundColor(ExcelRange cell, Color color)
        {
            cell.Style.Fill.PatternType = ExcelFillStyle.Gray125;
            cell.Style.Fill.PatternColor.SetColor(color);
            cell.Style.Fill.BackgroundColor.SetColor(color);
        }

        private void ApplyAlignmentHorizontal(ExcelRange cell, ExcelHorizontalAlignment alignment)
        {
            cell.Style.HorizontalAlignment = alignment;
        }

        private void ApplyAlignmentVertical(ExcelRange cell, ExcelVerticalAlignment alignment)
        {
            cell.Style.VerticalAlignment = alignment;
        }
        #endregion

        #region Writing File XLXS
        public void AddWorksheet(string titleWorksheet)
        {
            if (this.workbook == null) throw new Exception("The workbook instance can't be null.");
            if (titleWorksheet.Trim() == "") throw new Exception("The title worksheet can't be empty.");

            this.worksheet = this.workbook.Worksheets.Add(titleWorksheet);
        }

        public void BuildHeader(int row, int column, string content)
        {
            if (this.workbook == null) throw new Exception("The Workbook instance can't be null.");
            this.worksheet.Cells[row, column].Value = content;
            this.DrawnFontBold(this.worksheet.Cells[row, column]);
            this.DrawnBackgroundColor(this.worksheet.Cells[row, column], Color.CornflowerBlue);
            this.ApplyAlignmentHorizontal(this.worksheet.Cells[row, column], ExcelHorizontalAlignment.Center);
        }

        public void AddRow(int row, int column, string content)
        {
            this.worksheet.Cells[row, column].Value = content;
            this.ApplyAlignmentHorizontal(this.worksheet.Cells[row, column], ExcelHorizontalAlignment.Center);
        }

        public void SaveChanges()
        {
            byte[] packageToByte = this.package.GetAsByteArray();
            string filePath = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().Location).LocalPath);//Path.Combine(@"~\Files\ExcelDemo.xlsx");

            //write the file to the disk
            File.WriteAllBytes(filePath, packageToByte);

            //Instead of converting to bytes, you could also use FileInfo
            FileInfo fileInfo = new FileInfo(filePath);
            this.package.SaveAs(fileInfo);
        }
        #endregion

        #region Reading File XLXS
        public void ReadWorksheet(string worksheetName)
        {
            if (this.workbook == null) throw new Exception("The Workbook instance can't be null.");

            this.worksheet = this.workbook.Worksheets.Where(x => x.Name == worksheetName).FirstOrDefault();
        }

        public void GetRange(int rowInitial, int columnInitial)
        {
            var lastRow = this.GetLastRowFromWorksheet(this.worksheet, rowInitial, columnInitial);
        }

        private int? GetLastRowFromWorksheet(ExcelWorksheet worksheet, int rowInitial, int columnInitial)
        {
            rowInitial = rowInitial == 0 ? worksheet.Dimension.Start.Row : rowInitial;
            columnInitial = columnInitial == 0 ? worksheet.Dimension.Start.Column : columnInitial;
            int rowFinal = worksheet.Dimension.End.Row;
            int columnFinal = worksheet.Dimension.End.Column;

            return worksheet.Cells[rowInitial,columnInitial,rowFinal,columnFinal].OrderBy(c => c.Start.Row).Select(c => c.End.Row).Last();
        }
        #endregion */
    }
}
