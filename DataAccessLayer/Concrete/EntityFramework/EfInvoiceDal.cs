using Core.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Contexts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfInvoiceDal : EfEntityRepositoryBase<Invoices, EfDatabaseContext>, IInvoiceDal
    {
        //public List<Invoices> InvoiceDetails()
        //{
        //    using (var context=new EfDatabaseContext())
        //    {
        //        context.Invoices.Include(i => i.Customer);
        //    }
        //    return null;
               
        //}
    }
}
