using BusinessLogicLayer.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaturaUygulamasi.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var result = _customerService.GetList();
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int CustomersId)
        {
            var result = _customerService.GetById(CustomersId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getlistbyunitid")]
        public IActionResult GetCustomersById(int CustomersId)
        {
            var result = _customerService.GetById(CustomersId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Customers customer)
        {
            var result = _customerService.Add(customer);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Customers customer)
        {
            var result = _customerService.Update(customer);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Customers customer)
        {
            var result = _customerService.Delete(customer);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
