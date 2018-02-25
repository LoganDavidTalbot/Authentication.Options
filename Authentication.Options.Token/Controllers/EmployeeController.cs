using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Authentication.Options.Token.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Authorize]
        public List<Employee> GetEmployees()
        {
            using (var db = new TESTEntities())
            {
                var name = User.Identity.Name;
                var employees = db.Employees.ToList();
                return employees;
            }
        }
    }
}
