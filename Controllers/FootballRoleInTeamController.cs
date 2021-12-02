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
    [Route("/role")]
    public class RoleInTeamController : ControllerBase
    {
        [HttpPut]
        public RoleInTeam Create(RoleInTeam role)
        {
            Storage.RoleInTeamStorage.Create(role);
            return role;
        }

        [HttpGet]
        public RoleInTeam Read(int roleID)
        {
            return Storage.RoleInTeamStorage.Read(roleID);
        }

        [HttpPatch]
        public RoleInTeam Update(int roleID, RoleInTeam newRole)
        {
            return Storage.RoleInTeamStorage.Update(roleID);
        }

        [HttpDelete]
        public bool Delete(int roleID)
        {
            return Storage.RoleInTeamStorage.Delete(roleID);
        }
    }
}