using BusinessLogicLayer.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FaturaUygulamasi.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IAuthService _authService;

        public AuthController(ICustomerService customerService, IAuthService authService)
        {
            _customerService = customerService;
            //_authService = authService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var result = _customerService.GetList();
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(EmployeeForLoginDto employeeForLoginDto)
        {
            var employeeToLogin = _authService.Login(employeeForLoginDto);
            if (!employeeToLogin.Success)
            {
                return BadRequest(employeeToLogin);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, employeeToLogin.Data.Name),
                new Claim(ClaimTypes.Role, employeeToLogin.Data.RoleId.ToString()),
                new Claim(ClaimTypes.Email, employeeToLogin.Data.Id.ToString())
            };

            var userIdentity = new ClaimsIdentity(claims, "login");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
            return RedirectToAction("Index", "Home");


        }
    }
}
