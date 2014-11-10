namespace Warp.Data.Entities
{
    public partial class CustomCalendarDate
    {
        public int CustomCalendarDateId { get; set; }
        public int CustomCalendarId { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual CustomCalendar CustomCalendar { get; set; }
    }
}
