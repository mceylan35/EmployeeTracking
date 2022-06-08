using Core.Utilities.Results;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IAuthService
    {
       // IDataResult<AccessToken> CreateAccessToken(Employee user);
        IDataResult<Employee> Login(EmployeeForLoginDto loginDto);
        IDataResult<Employee> Register(EmployeeForRegisterDto registerDto, string password);
        IResult EmployeeExist(string email);
    }
}
