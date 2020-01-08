using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefaultTestUnit.Application.AppServices;
using DefaultTestUnit.Application.Interfaces.AppServices;
using DefaultTestUnit.Domain.Entities;
using System.Linq;
using System.Collections.Generic;

namespace DefaultTestUnit.Test.Units.Application.AppServices.Financial
{
    [TestClass]
    public class InvoiceAppServiceTesting
    {
        protected IInvoiceAppService _invoiceAppService;

        public InvoiceAppServiceTesting()
        {
            _invoiceAppService = new InvoiceAppService();
        }

        [TestMethod]
        public void Test_GetData_Should_Return_Something()
        {
            //Arrange
            var expected = new List<Invoice>();
            //Action
            var actual = _invoiceAppService.Get(Invoice => Invoice.Id == 2);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
