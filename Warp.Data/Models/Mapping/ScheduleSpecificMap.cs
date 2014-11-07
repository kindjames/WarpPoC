using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ScheduleSpecificMap : EntityTypeConfiguration<ScheduleSpecific>
    {
        public ScheduleSpecificMap()
        {
            // Primary Key
            this.HasKey(t => t.ScheduleSpecificId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ScheduleSpecific", "Subscriptions");
            this.Property(t => t.ScheduleSpecificId).HasColumnName("ScheduleSpecificId");
            this.Property(t => t.ScheduleId).HasColumnName("ScheduleId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Schedule)
                .WithMany(t => t.ScheduleSpecifics)
                .HasForeignKey(d => d.ScheduleId);

        }
    }
}
