using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace footaball.Controllers
{
    [ApiController]
    [Route("[[/Trener]]")]
    public class TrenerController : ControllerBase
    {
     
        [HttpPut("InformationAboutSquad")]
        public string InformationAboutSquad(string str)
        {
            return str; // Метод получения информации о составах команды
        }

        [HttpPut("RegistrationForTheMatch")]
        public string RegistrationForTheMatch(string str)
        {
            return str; // Метод записи команды на игру
        }

        [HttpPut("DeterminationOfPlayerEfficiency")]
        public string DeteminationOfPlayerEfficiency(string str)
        {
            return str; // Метод определения эффективности игрока
        }

        [HttpPost("PaymentOfSalariesToPlayers")]
        public string PaymentOfSalariesToPlayers(string str)
        {
            return str; // Методы выплаты игрокам зарплаты
        }

        }
    }

