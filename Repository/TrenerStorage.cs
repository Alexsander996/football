using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class TrenerStorage
    {
        private Dictionary<int, Trener> Treners { get; } = new Dictionary<int, Trener>();
        
        public void Create(Trener trener)
        {
            Treners.Add(trener.TrenerID, trener);
        }

        public Trener Read(int trenerID)
        {
            return Treners[trenerID];
        }

        public Trener Update(int trenerID, Trener newTrener)
        {
            Treners[trenerID] = newTrener;
            return Treners[trenerID];
        }

        public bool Delete(int trenerID)
        {
            return Treners.Remove(trenerID);
        }

    }
}