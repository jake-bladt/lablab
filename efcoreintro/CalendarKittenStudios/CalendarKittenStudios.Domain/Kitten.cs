using System;
using System.Collections.Generic;

namespace CalendarKittenStudios.Domain
{
    public class Kitten
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Born { get; set; }
        public String Breed { get; set; }
        public List<ModelingEngagement> Engagements { get; set; }
    }
}
