using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GitHub;
using GitHub.Repository;

namespace footaball.Controllers
{
    [ApiController]
    [Route("/salary")]
    public class SalaryController : ControllerBase
    {
        [HttpPut]
        public Salary Create(Salary salary)
        {
            Storage.SalaryStorage.Create(salary);
            return salary;
        }

        [HttpGet]
        public Salary Read(int salaryID)
        {
            return Storage.SalaryStorage.Read(salaryID);
        }

        [HttpPatch]
        public Salary Update(int salaryID, Salary newSalary)
        {
            return Storage.SalaryStorage.Update(salaryID, newSalary);
        }

        [HttpDelete]
        public bool Delete(int salaryID)
        {
            return Storage.SalaryStorage.Delete(salaryID);
        }
    }
}