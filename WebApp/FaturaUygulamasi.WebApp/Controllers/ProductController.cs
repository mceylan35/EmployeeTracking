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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService customerService)
        {
            _productService = customerService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var result = _productService.GetList();
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int CustomersId)
        {
            var result = _productService.GetById(CustomersId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getlistbyunitid")]
        public IActionResult GetCustomersById(int CustomersId)
        {
            var result = _productService.GetById(CustomersId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Products product)
        {
            var result = _productService.Add(product);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Products product)
        {
            var result = _productService.Update(product);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Products product)
        {
            var result = _productService.Delete(product);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
    }
}