using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuarterMap : EntityTypeConfiguration<Quarter>
    {
        public QuarterMap()
        {
            // Primary Key
            this.HasKey(t => t.QuarterId);

            // Properties
            this.Property(t => t.QuarterName)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Quarter", "Subscriptions");
            this.Property(t => t.QuarterId).HasColumnName("QuarterId");
            this.Property(t => t.QuarterName).HasColumnName("QuarterName");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
