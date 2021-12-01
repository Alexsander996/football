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
    [Route("/ticketstadium")]
    public class TicketStadiumController : ControllerBase
    {
        [HttpPut]
        public TicketOnStadium Create(TicketOnStadium ticketstadium)
        {
            Storage.TicketOnStadiumStorage.Create(ticketstadium);
            return ticketstadium;
        }

        [HttpGet]
        public TicketOnStadium Read(int ticketstadiumID)
        {
            return Storage.TicketOnStadiumStorage.Read(ticketstadiumID);
        }

        [HttpPatch]
        public TicketOnStadium Update(int ticketstadiumID, TicketOnStadium newTicketStadium)
        {
            return Storage.TicketOnStadiumStorage.Update(ticketstadiumID, newTicketStadium);
        }

        [HttpDelete]
        public bool Delete(int ticketstadium)
        {
            return Storage.TicketOnStadiumStorage.Delete(ticketstadium);
        }
    }
}