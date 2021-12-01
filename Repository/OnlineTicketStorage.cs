using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class OnlineTicketStorage
    {
        private Dictionary<int, OnlineTicket> OnlineTick { get; } = new Dictionary<int, OnlineTicket>();
 
        public void Create(OnlineTicket onlineTicket)
        {
            OnlineTick.Add(onlineTicket.OnlineTicketID, onlineTicket);
        }

        public OnlineTicket Read(int OnlineTicketID)
        {
            return OnlineTick[OnlineTicketID];
        }

        public OnlineTicket Update(int OnlineTicketID, OnlineTicket newOnlineTick)
        {
            OnlineTick[OnlineTicketID] = newOnlineTick;
            return OnlineTick[OnlineTicketID];
        }

        public bool Delete(int OnlineTicketID)
        {
            return OnlineTick.Remove(OnlineTicketID);
        }
    }
}