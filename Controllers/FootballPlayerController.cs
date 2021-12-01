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
    [Route("/player")]
    public class PlayerController : ControllerBase
    {
        [HttpPut]
        public Player Crate(Player player)
        {
            Storage.PlayerStorage.Create(player);
            return player;
        }
        [HttpGet]
        public Player Read(int playerID)
        {
            return Storage.PlayerStorage.Read(playerID);
        }
        [HttpPatch]
        public Player Update(int playerID, Player newPlayer)
        {
            return Storage.PlayerStorage.Update(playerID, newPlayer);
        }

        [HttpDelete]
        public bool Delete(int playerID)
        {
            return Storage.PlayerStorage.Delete(playerID);
        }

        [HttpGet("CheckSquad")]
        public string CheckSquad(string str)
        {
            return str; // метод просмотра состава на игру
        }

        [HttpGet("CheckBalance")]
        public string CheckBalance(string str)
        {
            return str; // метод проверки баланса
        }

        [HttpGet("CheckSchedule")]
        public string CheckSchedule(string str)
        {
            return str; // метод просмотра расписания
        }
    }
}
       


