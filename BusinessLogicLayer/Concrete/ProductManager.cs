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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IDataResult<Products> Add(Products product)
        {
            return new SuccessDataResult<Products>(_productDal.Add(product));
        }

        public IResult Delete(Products product)
        {
            _productDal.Delete(product);
            return new SuccessResult("The product has been deleted.");
        }

        public IDataResult<Products> GetById(int id)
        {
            return new SuccessDataResult<Products>(_productDal.GetAll().FirstOrDefault(x => x.Id == id));
        }

        public IDataResult<IList<Products>> GetList()
        {
            return new SuccessDataResult<IList<Products>>(_productDal.GetAll());
        }

        public IDataResult<Products> Update(Products product)
        {
            return new SuccessDataResult<Products>(_productDal.Update(product));
        }
    }
}
