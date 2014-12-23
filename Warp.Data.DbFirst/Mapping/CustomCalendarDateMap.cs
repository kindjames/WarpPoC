using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CustomCalendarDateMap : EntityTypeConfiguration<CustomCalendarDate>
    {
        public CustomCalendarDateMap()
        {
            // Primary Key
            HasKey(t => t.CustomCalendarDateId);

            // Properties
            // Table & Column Mappings
            ToTable("CustomCalendarDate", "Subscriptions");
            Property(t => t.CustomCalendarDateId).HasColumnName("CustomCalendarDateId");
            Property(t => t.CustomCalendarId).HasColumnName("CustomCalendarId");
            Property(t => t.Date).HasColumnName("Date");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.CustomCalendar)
                .WithMany(t => t.CustomCalendarDates)
                .HasForeignKey(d => d.CustomCalendarId);

        }
    }
}
