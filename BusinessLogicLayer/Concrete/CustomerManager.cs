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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IDataResult<Customers> Add(Customers customers)
        {
            return new SuccessDataResult<Customers>(_customerDal.Add(customers));
        }

        public IResult Delete(Customers customers)
        {
            _customerDal.Delete(customers);
            return new SuccessResult("The customer has been deleted.");
        }

        public IDataResult<Customers> GetById(int id)
        {
            return new SuccessDataResult<Customers>(_customerDal.GetAll().FirstOrDefault(x => x.Id == id));
        }

        public IDataResult<IList<Customers>> GetList()
        {
            return new SuccessDataResult<IList<Customers>>(_customerDal.GetAll());
        }

        public IDataResult<Customers> Update(Customers customers)
        {
            return new SuccessDataResult<Customers>(_customerDal.Update(customers));
        }
    }
}
