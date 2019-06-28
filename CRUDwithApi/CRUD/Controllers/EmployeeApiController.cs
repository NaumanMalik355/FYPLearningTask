using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeApiController(EmployeeContext context)
        {
            _context = context;
        }

        //GET   api/EmployeeApi
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployee()
        {
            return _context.Employees;
        }

        //GET   api/EmployeeApi/n
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeItem(int id)
        {
            var employeeItem = _context.Employees.Find(id);

            if (employeeItem == null)
            {
                return NotFound();
            }

            return employeeItem;
        }

        //POST  api/EmployeeApi
        [HttpPost]
        public ActionResult<Employee> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return CreatedAtAction("GetEmployeeItem", new Employee { EmployeeId = employee.EmployeeId }, employee);
        }

        //PUT   api/EmployeeApi/n
        [HttpPut("{id}")]
        public ActionResult PutEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        //DELETE    api/EmployeeApi/n
        [HttpDelete("{id}")]
        public ActionResult<Employee> DeleteEmployee(int id)
        {
            var employeeItem = _context.Employees.Find(id);
            if (employeeItem == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employeeItem);
            _context.SaveChanges();

            return employeeItem;
        }
    }
}