using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleCustomCalendarMap : EntityTypeConfiguration<ScheduleCustomCalendar>
    {
        public ScheduleCustomCalendarMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleCustomCalendarId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleCustomCalendar", "Subscriptions");
            Property(t => t.ScheduleCustomCalendarId).HasColumnName("ScheduleCustomCalendarId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.CustomCalendarId).HasColumnName("CustomCalendarId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.CustomCalendar)
                .WithMany(t => t.ScheduleCustomCalendars)
                .HasForeignKey(d => d.CustomCalendarId);
            HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleCustomCalendars)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
