using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookEvents.Web.Models
{
    public class UpcomingPassedEventsViewModel
    {
        public IEnumerable<EventViewModel> UpcomingEvents { get; set; }
        public IEnumerable<EventViewModel> PassedEvents { get; set; }
    }
}