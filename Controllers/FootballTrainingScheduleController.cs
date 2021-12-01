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
    [Route("/training")]
    public class TrainingScheduleController : ControllerBase
    {
        [HttpPut]
        public TrainingSchedule Create(TrainingSchedule training)
        {
            Storage.TrainingScheduleStorage.Create(training);
            return training;
        }

        [HttpGet]
        public TrainingSchedule Read(int trainingID)
        {
            return Storage.TrainingScheduleStorage.Read(trainingID);
        }

        [HttpPatch]
        public TrainingSchedule Update(int trainingID, TrainingSchedule newTraining)
        {
            return Storage.TrainingScheduleStorage.Update(trainingID, newTraining);
        }

        [HttpDelete]
        public bool Delete(int trainingID)
        {
            return Storage.TrainingScheduleStorage.Delete(trainingID);
        }
    }
}