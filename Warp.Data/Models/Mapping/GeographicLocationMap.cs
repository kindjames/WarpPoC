using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class GeographicLocationMap : EntityTypeConfiguration<GeographicLocation>
    {
        public GeographicLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicLocationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicLocation");
            this.Property(t => t.GeographicLocationID).HasColumnName("GeographicLocationID");
            this.Property(t => t.GeographicCounty).HasColumnName("GeographicCounty");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.GeographicCounty1)
                .WithMany(t => t.GeographicLocations)
                .HasForeignKey(d => d.GeographicCounty);

        }
    }
}
