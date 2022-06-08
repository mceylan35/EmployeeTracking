using BusinessLogicLayer.Abstract;
using Core.Utilities.Hashing;
using Core.Utilities.Results;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class AuthManager:IAuthService
    {
        private readonly IEmployeeService _employeeService;
        

        public AuthManager(IEmployeeService employeeService)
        {
            _employeeService = employeeService; 
        }
        public IDataResult<Employee> Register(EmployeeForRegisterDto registerDto, string password)
        {
            HashingHelper.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            var employee = new Employee
            {
              //  Email = registerDto.Email,
                Name = registerDto.FirstName,
                 SurName = registerDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                //Status = true,
            };
            var createdEmployee = _employeeService.Add(employee);
            return new SuccessDataResult<Employee>(createdEmployee.Data, createdEmployee.Message);
        }
        public IDataResult<Employee> Login(EmployeeForLoginDto loginDto)
        {
            var userCheck = _employeeService.GetByMail(loginDto.Email);
            if (userCheck == null) return new ErrorDataResult<Employee>(userCheck.Data, "Employee Not Found Id");
            if (!HashingHelper.VerifyPasswordHash(password: loginDto.Password,  userCheck.Data.PasswordHash, userCheck.Data.PasswordSalt))
                return new ErrorDataResult<Employee>(userCheck.Data, "Password Error");
            return new SuccessDataResult<Employee>(userCheck.Data, "Successful Login");
        }
        public IResult EmployeeExist(string email)
        {
            if (_employeeService.GetByMail(email) != null)
                return new ErrorResult("Employee Already Exists");
            return new SuccessResult();
        }
    }
}
