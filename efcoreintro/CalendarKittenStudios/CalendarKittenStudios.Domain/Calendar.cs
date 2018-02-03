using System;
using System.Collections.Generic;

namespace CalendarKittenStudios.Domain
{
    public class Calendar
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<CalendarPage> Pages { get; set; }
    }
}
