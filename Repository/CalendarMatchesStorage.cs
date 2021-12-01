using GitHub;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GitHub.Repository
{
    public class ClalendarMatchesStorage
    {
        private Dictionary<int, CalendarMatches> Calendars { get; } = new Dictionary<int, CalendarMatches>();
       
        public void Create(CalendarMatches calendar)
        {
            Calendars.Add(calendar.CalendarMatchesID, calendar);
        }

        public CalendarMatches Read(int CalendarID)
        {
            return Calendars[CalendarID];
        }

        public CalendarMatches Update(int CalendarID, CalendarMatches newCalendar)
        {
            Calendars[CalendarID] = newCalendar;
            return Calendars[CalendarID];
        }

        public bool Delete(int CalendarID)
        {
            return Calendars.Remove(CalendarID);
        }
    }
}