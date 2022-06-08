using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.BusinessAutofac.Autofac;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        [Authorize("Admin")]
        public IDataResult<Employee> Add(Employee employee)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Add(employee));
        }
         
        [SecureOperation("Employee.Delete,Admin")]
        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult("The product has been deleted.");
        }

        public IDataResult<Employee> GetById(int id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.GetAll().FirstOrDefault(x => x.Id == id));
        }

        public IDataResult<Employee> GetByMail(string email)
        {
            return null;// new SuccessDataResult<Employee>(_employeeDal.Get(u=>u.Email==email));
        }

        public IDataResult<List<OperationClaim>> GetClaims(Employee employee)
        {
            return new SuccessDataResult<List<OperationClaim>>(_employeeDal.GetClaims(employee));
        }

        public IDataResult<IList<Employee>> GetList()
        {
            return new SuccessDataResult<IList<Employee>>(_employeeDal.GetAll());
        }

        public object Login(EmployeeForLoginDto employeeForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Employee> Update(Employee employee)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Update(employee));
        }
    }
}
