using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class GeographicPostCodeMap : EntityTypeConfiguration<GeographicPostCode>
    {
        public GeographicPostCodeMap()
        {
            // Primary Key
            HasKey(t => t.GeographicPostCodeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("GeographicPostCode", "Geographic");
            Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            Property(t => t.GeographicPostalAreaId).HasColumnName("GeographicPostalAreaID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.XCoordinate).HasColumnName("XCoordinate");
            Property(t => t.YCoordinate).HasColumnName("YCoordinate");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.GeographicPostalArea)
                .WithMany(t => t.GeographicPostCodes)
                .HasForeignKey(d => d.GeographicPostalAreaId);

        }
    }
}
