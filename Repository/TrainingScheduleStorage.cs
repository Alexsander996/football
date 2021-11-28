using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class TrainingScheduleStorage
    {
        private Dictionary<int, TraningScheduleDomain> Schedule { get; } = new Dictionary<int, TraningScheduleDomain>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(TraningScheduleDomain traning)
        {
            Schedule.Add(traning.TrainingScheduleID, traning);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public TraningScheduleDomain Read(int TrainingScheduleID)
        {
            return Schedule[TrainingScheduleID];
        }

        public TraningScheduleDomain Update(int TrainingScheduleID, TraningScheduleDomain newTraining)
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