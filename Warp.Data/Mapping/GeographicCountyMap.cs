using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class GeographicCountyMap : EntityTypeConfiguration<GeographicCounty>
    {
        public GeographicCountyMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicCountyId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicCounty", "Geographic");
            this.Property(t => t.GeographicCountyId).HasColumnName("GeographicCountyID");
            this.Property(t => t.GeographicRegionId).HasColumnName("GeographicRegionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.GeographicRegion)
                .WithMany(t => t.GeographicCounties)
                .HasForeignKey(d => d.GeographicRegionId);

        }
    }
}
