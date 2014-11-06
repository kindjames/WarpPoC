using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class GeographicCountyMap : EntityTypeConfiguration<GeographicCounty>
    {
        public GeographicCountyMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicCountyID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicCounty");
            this.Property(t => t.GeographicCountyID).HasColumnName("GeographicCountyID");
            this.Property(t => t.GeographicRegionID).HasColumnName("GeographicRegionID");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.GeographicRegion)
                .WithMany(t => t.GeographicCounties)
                .HasForeignKey(d => d.GeographicRegionID);

        }
    }
}
