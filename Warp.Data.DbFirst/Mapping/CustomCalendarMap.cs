using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CustomCalendarMap : EntityTypeConfiguration<CustomCalendar>
    {
        public CustomCalendarMap()
        {
            // Primary Key
            HasKey(t => t.CustomCalendarId);

            // Properties
            Property(t => t.CustomCalendarName)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("CustomCalendar", "Subscriptions");
            Property(t => t.CustomCalendarId).HasColumnName("CustomCalendarId");
            Property(t => t.CustomCalendarName).HasColumnName("CustomCalendarName");
            Property(t => t.Owner).HasColumnName("Owner");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
