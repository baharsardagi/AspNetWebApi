using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        Employee[] employees = new Employee[]
        {
            new Employee {ID=1,FirstName="John",LastName="Taylor", StartDate=DateTime.Parse(DateTime.Today.ToString()),Age=25},
            new Employee{ID=2,FirstName="Maria",LastName="Wilson", StartDate=DateTime.Parse(DateTime.Today.ToString()),Age=20},
            new Employee {ID=3,FirstName="Helen",LastName="Baker",StartDate=DateTime.Parse(DateTime.Today.ToString()),Age=30},
            new Employee {ID=4,FirstName="James",LastName="Allen",StartDate=DateTime.Parse(DateTime.Today.ToString()),Age=28}
        };

        public IEnumerable<Employee> GetAllEmployees()
        {

            return employees;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.ID == id);

            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);

        }



    }
}
