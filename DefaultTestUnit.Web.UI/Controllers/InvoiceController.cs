using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DefaultTestUnit.Application.AppServices;
using DefaultTestUnit.Application.Interfaces.AppServices;
using DefaultTestUnit.Domain.Entities;

namespace DefaultTestUnit.Web.UI.Controllers
{
    public class InvoiceController : Controller
    {
        protected IInvoiceAppService _invoiceAppService;

        public InvoiceController()
        {
            _invoiceAppService = new InvoiceAppService();
        }
        // GET: Invoice
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            return Json(_invoiceAppService.GetAll().ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}