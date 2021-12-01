using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GitHub.Repository;
using GitHub;

namespace football.Controllers
{
    [ApiController]
    [Route("/trener")]
    public class TrenerController : ControllerBase
    {
        [HttpPut]
        public Trener Create(Trener trener)
        {
            Storage.TrenerStorage.Create(trener);
            return trener;
        }
        [HttpGet]
        public Trener Read(int trenerID)
        {
            return Storage.TrenerStorage.Read(trenerID);
        }
        [HttpPatch]
        public Trener Update(int trenerID, Trener newTrener)
        {
            return Storage.TrenerStorage.Update(trenerID, newTrener);
        }
        [HttpDelete]
        public bool Delete(int trenerID)
        {
            return Storage.TrenerStorage.Delete(trenerID);
        }

        [HttpGet("RecordingTeamForMatch")]
        public string RecordingTeamForMatch(string str)
        {
            return str; // метод записи команды на матч
        }

        [HttpGet("MakeTrainingSchedule")]
        public string MakeTrainingSchedule(string str)
        {
            return str; // метод составсления тренировок
        }

        [HttpGet("ChangeTransferStatus")]
        public string ChangeTransferStatus(string str)
        {
            return str; // метод смены трансферного статуса игрока
        }

        [HttpGet("ExamineTrainingPerfom")]
        public string ExamineTrainingPerfom(string str)
        {
            return str; // метод изучения выполнения тренировок игроком
        }

        [HttpGet("PlayerBalance")]
        public string PlayerBalance(string str)
        {
            return str; // метод начисления зарплаты игроку
        }
    }
}
