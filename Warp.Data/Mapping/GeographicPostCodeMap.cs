using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class GeographicPostCodeMap : EntityTypeConfiguration<GeographicPostCode>
    {
        public GeographicPostCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicPostCodeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicPostCode", "Geographic");
            this.Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            this.Property(t => t.GeographicPostalAreaId).HasColumnName("GeographicPostalAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.XCoordinate).HasColumnName("XCoordinate");
            this.Property(t => t.YCoordinate).HasColumnName("YCoordinate");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.GeographicPostalArea)
                .WithMany(t => t.GeographicPostCodes)
                .HasForeignKey(d => d.GeographicPostalAreaId);

        }
    }
}
