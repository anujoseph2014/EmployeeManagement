using EmployeeManagement.Server.DataAccess.Context;
using EmployeeManagement.Server.DataAccess.Interfaces;
using EmployeeManagement.Server.Helpers;
using EmployeeManagement.Server.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _empRepo;
        public EmployeeController(IEmployeeRepository empRepo)
        {
            _empRepo = empRepo;
        }
        // GET: api/<EmployeeController>
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                List<Employee> employees = await _empRepo.GetEmployee();
                return Ok(employees);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }           
        }

        // POST api/<EmployeeController>
        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeDto empDto)
        {
            try
            {
               int empId= await _empRepo.CreateEmployee(empDto.ToEntity());
               return Ok( new { EmpId = empId });    
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //// DELETE api/<EmployeeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
