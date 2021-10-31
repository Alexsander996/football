using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace footaball.Controllers
{
    [ApiController]
    [Route("/Player")]
    public class PlayerController : ControllerBase
    {
        [HttpPut("GettingSalary")]
        public string GettingSalary(string str)
        {
            return str; // Метод получения зарплаты игроком
        }
        [HttpGet("InfomationAboutSquadOnMath")]
        public string InformationAboutSquadOnMath(string str)
        {
            return str; // Метод просмотра состава на игру
        }
        [HttpGet("ViewTimetableTraning")]
        public string ViewTimetableTraning(string str)
        {
            return str; // Метод просмотра расписания тренировок
        }
    }
}
       


