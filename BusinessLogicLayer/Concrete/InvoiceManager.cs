using BusinessLogicLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        private readonly IInvoiceDal _invoiceDal;
        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }
        public IDataResult<Invoices> Add(Invoices invoices)
        {
            return new SuccessDataResult<Invoices>(_invoiceDal.Add(invoices));
        }

        public IResult Delete(Invoices invoices)
        {
            _invoiceDal.Delete(invoices);
            return new SuccessResult("The invoice has been deleted.");
        }

        public IDataResult<Invoices> GetById(int id)
        {
            return new SuccessDataResult<Invoices>(_invoiceDal.GetAll().FirstOrDefault(x => x.Id == id));
        }

        public IDataResult<IList<Invoices>> GetList()
        {
            return new SuccessDataResult<IList<Invoices>>(_invoiceDal.GetAll());
        }

        public IDataResult<Invoices> Update(Invoices invoices)
        {
            return new SuccessDataResult<Invoices>(_invoiceDal.Update(invoices));
        }
    }
}
