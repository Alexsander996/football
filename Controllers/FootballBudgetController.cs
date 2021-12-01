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
    [Route("/budget")]
    public class BudgetController : ControllerBase
    {
        [HttpPut]
        public Budget Create(Budget budget)
        {
            Storage.BudgetStorage.Create(budget);
            return budget;
        }

        [HttpGet]
        public Budget Read(int budgetID)
        {
            return Storage.BudgetStorage.Read(budgetID);
        }

        [HttpPatch]
        public Budget Update(int bugdetID,Budget newBudget)
        {
            return Storage.BudgetStorage.Update(bugdetID,newBudget);
        }

        [HttpDelete]
        public bool Delete(int budgetID)
        {
            return Storage.BudgetStorage.Delete(budgetID);
        }
    }
}