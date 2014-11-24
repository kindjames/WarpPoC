using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CustomCalendarMap : EntityTypeConfiguration<CustomCalendar>
    {
        public CustomCalendarMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomCalendarId);

            // Properties
            this.Property(t => t.CustomCalendarName)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("CustomCalendar", "Subscriptions");
            this.Property(t => t.CustomCalendarId).HasColumnName("CustomCalendarId");
            this.Property(t => t.CustomCalendarName).HasColumnName("CustomCalendarName");
            this.Property(t => t.Owner).HasColumnName("Owner");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
