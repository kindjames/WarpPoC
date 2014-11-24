using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CustomCalendarDateMap : EntityTypeConfiguration<CustomCalendarDate>
    {
        public CustomCalendarDateMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomCalendarDateId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CustomCalendarDate", "Subscriptions");
            this.Property(t => t.CustomCalendarDateId).HasColumnName("CustomCalendarDateId");
            this.Property(t => t.CustomCalendarId).HasColumnName("CustomCalendarId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CustomCalendar)
                .WithMany(t => t.CustomCalendarDates)
                .HasForeignKey(d => d.CustomCalendarId);

        }
    }
}
