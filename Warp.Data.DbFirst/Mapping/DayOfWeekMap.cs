using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DayOfWeekMap : EntityTypeConfiguration<DayOfWeek>
    {
        public DayOfWeekMap()
        {
            // Primary Key
            HasKey(t => t.DayOfWeekId);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("DayOfWeek", "Subscriptions");
            Property(t => t.DayOfWeekId).HasColumnName("DayOfWeekId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
