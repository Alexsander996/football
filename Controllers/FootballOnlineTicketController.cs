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
    [Route("/onlineticket")]
    public class OnlineTicketController : ControllerBase
    {
        [HttpPut]
        public OnlineTicket Create(OnlineTicket online)
        {
            Storage.OnlineTicketStorage.Create(online);
            return online;
        }

        [HttpGet]
        public OnlineTicket Read(int onlineticketID)
        {
            return Storage.OnlineTicketStorage.Read(onlineticketID);
        }

        [HttpPatch]
        public OnlineTicket Update(int onlineticketID, OnlineTicket newOnlineticket)
        {
            return Storage.OnlineTicketStorage.Update(onlineticketID, newOnlineticket);
        }

        [HttpDelete]
        public bool Delete(int onlineticketID)
        {
            return Storage.OnlineTicketStorage.Delete(onlineticketID);
        }
    }
}