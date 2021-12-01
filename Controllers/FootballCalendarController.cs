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
    [Route("/calendar")]
    public class CalendarController : ControllerBase
    {
        [HttpPut]
        public CalendarMatches Create(CalendarMatches calendar)
        {
            Storage.ClalendarMatchesStorage.Create(calendar);
            return calendar;
        }

        [HttpGet]
        public CalendarMatches Read(int calendarID)
        {
            return Storage.ClalendarMatchesStorage.Read(calendarID);
        }

        [HttpPatch]
        public CalendarMatches Update(int calendarID, CalendarMatches newCalendar)
        {
            return Storage.ClalendarMatchesStorage.Update(calendarID, newCalendar);
        }

        [HttpDelete]
        public bool Delete(int calendarID)
        {
            return Storage.ClalendarMatchesStorage.Delete(calendarID);
        }
    }
}