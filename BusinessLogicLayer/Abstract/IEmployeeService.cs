using Core.Utilities.Results;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<IList<Employee>> GetList();
        IDataResult<Employee> GetById(int id);
        IDataResult<Employee> Add(Employee employee);
        IDataResult<Employee> Update(Employee employee);
        IResult Delete(Employee employee);
        IDataResult<List<OperationClaim>> GetClaims(Employee employee);
        IDataResult<Employee> GetByMail(string email);
    }
}
