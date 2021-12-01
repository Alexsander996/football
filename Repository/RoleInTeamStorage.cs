using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class RoleInTeamStorage
    {
        private Dictionary<int, RoleInTeam> Roles { get; } = new Dictionary<int, RoleInTeam>();

        public void Create(RoleInTeam role)
        {
            Roles.Add(role.RoleID, role);
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