using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class SquadOnMatchStorage
    {
        private Dictionary<int, SquadOnMatch> Squads { get; } = new Dictionary<int, SquadOnMatch>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(SquadOnMatch squad)
        {
            Squads.Add(squad.SquadOnMatchID, squad);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public SquadOnMatch Read(int SquadOnMatchID)
        {
            return Squads[SquadOnMatchID];
        }

        public SquadOnMatch Update(int SquadOnMatchID, SquadOnMatch newSquad)
        {
            Squads[SquadOnMatchID] = newSquad;
            return Squads[SquadOnMatchID];
        }

        public bool Delete(int SquadOnMatchID)
        {
            return Squads.Remove(SquadOnMatchID);
        }
    }
}