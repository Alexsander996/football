using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class PlayerStorage
    {
        private Dictionary<int, Player> Players { get; } = new Dictionary<int, Player>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Player player)
        {
            Players.Add(player.PlayerID, player);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Player Read(int PlayerID)
        {
            return Players[PlayerID];
        }

        public Player Update(int PlayerID, Player newPlayer)
        {
            Players[PlayerID] = newPlayer;
            return Players[PlayerID];
        }

        public bool Delete(int PlayerID)
        {
            return Players.Remove(PlayerID);
        }
    }
}