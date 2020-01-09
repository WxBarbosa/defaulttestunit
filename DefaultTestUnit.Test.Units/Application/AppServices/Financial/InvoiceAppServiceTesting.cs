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
        private IInvoiceAppService _invoiceAppService;

        public InvoiceAppServiceTesting()
        {
            _invoiceAppService = new InvoiceAppService();
        }

        [TestInitialize]
        public void Initialize()
        {
            _invoiceAppService = new InvoiceAppService();
        }

        [TestMethod]
        public void Test_GetData_Should_Return_SomeResult()
        {
            //Arrange
            var expected = 1;
            //Action
            var actual = _invoiceAppService.Get(x => x.Id == 1).ToList().Count();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
