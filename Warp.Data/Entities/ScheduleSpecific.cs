namespace Warp.Data.Entities
{
    public partial class ScheduleSpecific
    {
        public int ScheduleSpecificId { get; set; }
        public int ScheduleId { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
