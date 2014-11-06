using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class GeographicPostalAreaMap : EntityTypeConfiguration<GeographicPostalArea>
    {
        public GeographicPostalAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicPostalAreaID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicPostalArea");
            this.Property(t => t.GeographicPostalAreaID).HasColumnName("GeographicPostalAreaID");
            this.Property(t => t.GeographicLocationID).HasColumnName("GeographicLocationID");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.GeographicLocation)
                .WithMany(t => t.GeographicPostalAreas)
                .HasForeignKey(d => d.GeographicLocationID);

        }
    }
}
