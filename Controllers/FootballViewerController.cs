using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace footaball.Controllers
{
    [ApiController]
    [Route("[[/Viewer]]")]
    public class ViewerController : ControllerBase
    {
     
        [HttpGet("WatchingTheMach")]
        public string WatchingTheMach(string str)
        {
            return str; // Метод просмотра матча
        }

        [HttpGet("ChoosingTheWorstAndTheBestPlayer")]
        public string ChoosingTheWorstAndTheBestPlayer(string str)
        {
            return str; // Метод выбора худшего и лучшего игрока
        }

        [HttpPut("PayTheTicket")]
        public string PayTheTicket(string str)
        {
            return str; // Метод покупки билета
        }

        }
    }

