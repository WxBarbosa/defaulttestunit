using DefaultTestUnit.Application.Interfaces.AppServices;
using System;
using System.Collections.Generic;
using System.Text;
using DefaultTestUnit.Domain.Entities;
using DefaultTestUnit.Domain.Helpers;
using DefaultTestUnit.Infrastructure.Data.Context;
using DefaultTestUnit.Application.Interfaces;
using System.Linq;

namespace DefaultTestUnit.Application.AppServices
{
    public class InvoiceAppService : AppServiceBase<Invoice>, IInvoiceAppService
    {

        private readonly Context _db;

        public InvoiceAppService()
        {
            _db = new Context();
        }
    }
}
