using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class GeographicRegionMap : EntityTypeConfiguration<GeographicRegion>
    {
        public GeographicRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicRegionId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicRegion", "Geographic");
            this.Property(t => t.GeographicRegionId).HasColumnName("GeographicRegionID");
            this.Property(t => t.GeographicCountryId).HasColumnName("GeographicCountryID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.GeographicCountry)
                .WithMany(t => t.GeographicRegions)
                .HasForeignKey(d => d.GeographicCountryId);

        }
    }
}
