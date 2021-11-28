using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class TicketOnStadiumStorage
    {
        private Dictionary<int, TicketOnStadium> StadiumTick { get; } = new Dictionary<int, TicketOnStadium>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();


        public void Create(TicketOnStadium stadium)
        {
            StadiumTick.Add(stadium.TicketOnStadiumID, stadium);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public TicketOnStadium Read(int TicketOnStadiumID)
        {
            return StadiumTick[TicketOnStadiumID];
        }

        public TicketOnStadium Update(int TicketOnStadiumID, TicketOnStadium newTicketStadium)
        {
            StadiumTick[TicketOnStadiumID] = newTicketStadium;
            return StadiumTick[TicketOnStadiumID];
        }

        public bool Delete(int TicketOnStadiumID)
        {
            return StadiumTick.Remove(TicketOnStadiumID);
        }
    }
}