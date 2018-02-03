using System;
using System.Collections.Generic;

namespace CalendarKittenStudios.Domain
{
    public class CalendarPage
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Photographer Photographer { get; set; }
        public List<Kitten> Kittens { get; set; }
    }
}
