using Core.DataAccess;
using Core.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Contexts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, EfDatabaseContext>, IEmployeeDal
    {
        public List<OperationClaim> GetClaims(Employee employee)
        {
             using(var context=new EfDatabaseContext())
             {

                var result = from operationClaim in context.OperationClaims
                             join emp in context.EmployeeOperationClaims
                             on operationClaim.Id equals emp.OperationClaimId
                             where emp.OperationClaimId == employee.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
            
        }
    }
}
