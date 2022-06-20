using Core.Utilities.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IProductService
    {
        IDataResult<IList<Products>> GetList();
        IDataResult<Products> GetById(int id);
        IDataResult<Products> Add(Products product);
        IDataResult<Products> Update(Products product);
        IResult Delete(Products product);
    }
}
