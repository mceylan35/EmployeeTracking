using Core.Utilities.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface ICustomerService
    {
        IDataResult<IList<Customers>> GetList();
        IDataResult<Customers> GetById(int id);
        IDataResult<Customers> Add(Customers customers);
        IDataResult<Customers> Update(Customers customers);
        IResult Delete(Customers customers);
    }
}
