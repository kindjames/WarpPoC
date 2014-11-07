using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class GeographicPostCodeMap : EntityTypeConfiguration<GeographicPostCode>
    {
        public GeographicPostCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicPostCodeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicPostCode", "Geographic");
            this.Property(t => t.GeographicPostCodeID).HasColumnName("GeographicPostCodeID");
            this.Property(t => t.GeographicPostalAreaID).HasColumnName("GeographicPostalAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.XCoordinate).HasColumnName("XCoordinate");
            this.Property(t => t.YCoordinate).HasColumnName("YCoordinate");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.GeographicPostalArea)
                .WithMany(t => t.GeographicPostCodes)
                .HasForeignKey(d => d.GeographicPostalAreaID);

        }
    }
}
