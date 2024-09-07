using ApplicationLayer.Interfaces;
using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IEmployee _employee;

        public EmployeesController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employeesList = await _employee.GetAllAsync();
            return Ok(employeesList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _employee.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var response = await _employee.AddAsync(employee);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var response = await _employee.DeleteAsync(id);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employee) { 
            var response = await _employee.UpdateAsync(employee);
            return Ok(response);
        }
    }
}
