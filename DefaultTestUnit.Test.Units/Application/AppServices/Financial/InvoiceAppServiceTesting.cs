using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefaultTestUnit.Application.AppServices;
using DefaultTestUnit.Application.Interfaces.AppServices;
using DefaultTestUnit.Domain.Entities;
using System.Linq;
using System.Collections.Generic;
using Moq;

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
        public void GetInvoice_ShouldBe_Returned_Invoice()
        {
            //Arrange
            Invoice invoice = new Invoice()
            {
                Id = 1,
                Code = "12121",
                Total = 200
            };

            Mock<IInvoiceAppService> mock = new Mock<IInvoiceAppService>();
            mock.Setup(x => x.FindByKeys(1)).Returns(invoice);
            //Action
            var expected = mock.Object.FindByKeys(1);
            var actual = _invoiceAppService.FindByKeys(1);
            //Assert
            Assert.AreEqual(expected.Id, actual.Id);
        }
    }
}
