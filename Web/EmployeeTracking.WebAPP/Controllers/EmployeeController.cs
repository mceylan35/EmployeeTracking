using BusinessLogicLayer.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTracking.WebAPP.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        
        [HttpGet]
        public IActionResult GetList()
        {
            var result = _employeeService.GetList();
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int employeeId)
        {
            var result = _employeeService.GetById(employeeId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpGet("getlistbyunitid")]
        public IActionResult GetEmployeeById(int employeeId)
        {
            var result = _employeeService.GetById(employeeId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Employee employee)
        {
            var result = _employeeService.Add(employee);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Employee employee)
        {
            var result = _employeeService.Update(employee);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Employee employee)
        {
            var result = _employeeService.Delete(employee);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
