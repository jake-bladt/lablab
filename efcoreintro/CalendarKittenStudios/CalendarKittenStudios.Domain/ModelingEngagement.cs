namespace CalendarKittenStudios.Domain
{
    public class ModelingEngagement
    {
        public int KittenID { get; set; }
        public Kitten Kitten { get; set; }
        public int CalendarPageID { get; set; }
        public CalendarPage CalendarPage { get; set; }
    }
}
