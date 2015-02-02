using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuarterMap : EntityTypeConfiguration<Quarter>
    {
        public QuarterMap()
        {
            // Primary Key
            HasKey(t => t.QuarterId);

            // Properties
            Property(t => t.QuarterName)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Quarter", "Subscriptions");
            Property(t => t.QuarterId).HasColumnName("QuarterId");
            Property(t => t.QuarterName).HasColumnName("QuarterName");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
