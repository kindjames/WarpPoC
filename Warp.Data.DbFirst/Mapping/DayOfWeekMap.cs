using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DayOfWeekMap : EntityTypeConfiguration<DayOfWeek>
    {
        public DayOfWeekMap()
        {
            // Primary Key
            this.HasKey(t => t.DayOfWeekId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DayOfWeek", "Subscriptions");
            this.Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
