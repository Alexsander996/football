using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class TrainingScheduleStorage
    {
        private Dictionary<int, TrainingSchedule> Schedule { get; } = new Dictionary<int, TrainingSchedule>();

        public void Create(TrainingSchedule traning)
        {
            Schedule.Add(traning.TrainingScheduleID, traning);
        }

        public TrainingSchedule Read(int TrainingScheduleID)
        {
            return Schedule[TrainingScheduleID];
        }

        public TrainingSchedule Update(int TrainingScheduleID, TrainingSchedule newTraining)
        {
            Schedule[TrainingScheduleID] = newTraining;
            return Schedule[TrainingScheduleID];
        }

        public bool Delete(int TrainingScheduleID)
        {
            return Schedule.Remove(TrainingScheduleID);
        }
    }
}