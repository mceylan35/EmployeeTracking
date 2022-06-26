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
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var result = _invoiceService.GetList();
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int employeeId)
        {
            var result = _invoiceService.GetById(employeeId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getlistbyunitid")]
        public IActionResult GetEmployeeById(int employeeId)
        {
            var result = _invoiceService.GetById(employeeId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Invoices invoice)
        {
            var result = _invoiceService.Add(invoice);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Invoices invoice)
        {
            var result = _invoiceService.Update(invoice);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Invoices invoice)
        {
            var result = _invoiceService.Delete(invoice);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
