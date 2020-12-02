using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : EntitiesController<Employee>
    {
        IEmployeeService _employeeService;
        //IBaseService<Employee> _baseService;
        public EmployeesController(IEmployeeService employeeService) :base(employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("getbyprocedure")]
        public IActionResult GetEntitiesByProc([FromQuery]string procedureName)
        {
            var entities = _employeeService.GetEmployeeByProc(procedureName);
            return Ok(entities);
        }
        [HttpGet("search")]
        public IActionResult GetEntitiesByCodeNamePhone([FromQuery] string procedureName, [FromQuery] string searchtext)
        {
            var entities = _employeeService.GetEmployeeByCodeNamePhone(procedureName, searchtext);
            return Ok(entities);
        }
        // GET: api/<EmployeesController>
        //[HttpGet]
        //public IEnumerable<Employee> Get()
        //{
        //    return _employeeService.GetEmployees();
        //}

        //// GET api/<EmployeesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<EmployeesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<EmployeesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EmployeesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
