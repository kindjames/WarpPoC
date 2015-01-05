using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ScheduleSpecificMap : EntityTypeConfiguration<ScheduleSpecific>
    {
        public ScheduleSpecificMap()
        {
            // Primary Key
            HasKey(t => t.ScheduleSpecificId);

            // Properties
            // Table & Column Mappings
            ToTable("ScheduleSpecific", "Subscriptions");
            Property(t => t.ScheduleSpecificId).HasColumnName("ScheduleSpecificId");
            Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            Property(t => t.Date).HasColumnName("Date");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Schedule)
                .WithMany(t => t.ScheduleSpecifics)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
