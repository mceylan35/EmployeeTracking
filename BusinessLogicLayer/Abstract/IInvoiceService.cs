using Core.Utilities.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IInvoiceService
    {
        IDataResult<IList<Invoices>> GetList();
        IDataResult<Invoices> GetById(int id);
        IDataResult<Invoices> Add(Invoices invoices);
        IDataResult<Invoices> Update(Invoices invoices);
        IResult Delete(Invoices invoices);
    }
}
