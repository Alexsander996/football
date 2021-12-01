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
    [Route("/squad")]
    public class SquadController : ControllerBase
    {
        [HttpPut]
        public SquadOnMatch Create(SquadOnMatch squad)
        {
            Storage.SquadOnMatchStorage.Create(squad);
            return squad;
        }

        [HttpGet]
        public SquadOnMatch Read(int squadID)
        {
            return Storage.SquadOnMatchStorage.Read(squadID);
        }

        [HttpPatch]
        public SquadOnMatch Update(int squadID, SquadOnMatch newSquad)
        {
            return Storage.SquadOnMatchStorage.Update(squadID, newSquad);
        }

        [HttpDelete]
        public bool Delete(int squadID)
        {
            return Storage.SquadOnMatchStorage.Delete(squadID);
        }
    }
}