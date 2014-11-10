using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ScheduleCustomCalendarMap : EntityTypeConfiguration<ScheduleCustomCalendar>
    {
        public ScheduleCustomCalendarMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleCustomCalendarId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleCustomCalendar", "Subscriptions");
            this.Property(t => t.ScheduleCustomCalendarId).HasColumnName("ScheduleCustomCalendarId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.CustomCalendarId).HasColumnName("CustomCalendarId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.CustomCalendar)
                .WithMany(t => t.ScheduleCustomCalendars)
                .HasForeignKey(d => d.CustomCalendarId);
            this.HasOptional(t => t.Schedule)
                .WithMany(t => t.ScheduleCustomCalendars)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
