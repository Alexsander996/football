using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class SquadOnMatchStorage
    {
        private Dictionary<int, SquadOnMatch> Squads { get; } = new Dictionary<int, SquadOnMatch>();

        public void Create(SquadOnMatch squad)
        {
            Squads.Add(squad.SquadOnMatchID, squad);
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