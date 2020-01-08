using System;
using System.Collections.Generic;
using System.Text;
using DefaultTestUnit.Domain.Helpers;
using DefaultTestUnit.Domain.Entities;

namespace DefaultTestUnit.Application.Interfaces.AppServices
{
    public interface IInvoiceAppService : IAppServiceBase<Invoice>, IDisposable
    {
    }
}
