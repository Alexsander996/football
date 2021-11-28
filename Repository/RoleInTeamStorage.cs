using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class RoleInTeamStorage
    {
        private Dictionary<int, RoleInTeam> Roles { get; } = new Dictionary<int, RoleInTeam>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(RoleInTeam role)
        {
            Roles.Add(role.RoleID, role);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public RoleInTeam Read(int RoleID)
        {
            return Roles[RoleID];
        }

        public RoleInTeam Update(int RoleID, RoleInTeam newRole)
        {
            Roles[RoleID] = newRole;
            return Roles[RoleID];
        }

        public bool Delete(int RoleID)
        {
            return Roles.Remove(RoleID);
        }
    }
}