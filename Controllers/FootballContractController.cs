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
    [Route("/contract")]
    public class ContractController : ControllerBase
    {
        [HttpPut]
        public Contract Create(Contract contract)
        {
            Storage.ContractStorage.Create(contract);
            return contract;
        }

        [HttpGet]
        public Contract Read(int contractID)
        {
            return Storage.ContractStorage.Read(contractID);
        }

        [HttpPatch]
        public Contract Update(int contractID, Contract newContract)
        {
            return Storage.ContractStorage.Update(contractID, newContract);
        }

        [HttpDelete]
        public bool Delete(int contractID)
        {
            return Storage.ContractStorage.Delete(contractID);
        }
    }
}