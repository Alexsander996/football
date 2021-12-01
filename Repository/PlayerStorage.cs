using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class PlayerStorage
    {
        private Dictionary<int, Player> Players { get; } = new Dictionary<int, Player>();

        public void Create(Player player)
        {
            Players.Add(player.PlayerID, player);
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