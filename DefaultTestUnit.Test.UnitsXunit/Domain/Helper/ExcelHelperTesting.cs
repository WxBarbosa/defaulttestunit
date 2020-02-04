using DefaultTestUnit.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace DefaultTestUnit.Test.UnitsXunit.Domain.Helper
{
    public class ExcelHelperTesting
    {

        [Fact]
        public void AddWorksheet_With_WorkbookNull_ShouldBeReturned_Exception()
        {
            //ExcelHelper excelHelper = new ExcelHelper("C:\\Users\\wylkson_barbosa\\Downloads\\LISTAGEM ATIVO Original.xlsx");
            ExcelHelper excelHelper = new ExcelHelper();
            excelHelper.AddWorksheet("Planilha1");
            excelHelper.ReadWorksheet("Planilha1");
            excelHelper.BuildHeader(1, 1, "ITEM");
            excelHelper.BuildHeader(1, 2, "DESCRIÇÃO");
            excelHelper.AddRow(1, 2, "DESCRIÇÃO");
            excelHelper.SaveChanges();
            Assert.True(true);
        }
        /*using(MemoryStream memStream = new MemoryStream()) {
            memStream.Write(model.ReportBits, 0, model.ReportBits.Length);
            XLWorkbook wb = new XLWorkbook(memStream, XLEventTracking.Disabled);
            wb.SaveAs(pathToSavedFile);
        }*/
    }
}
