using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class GeographicRegionMap : EntityTypeConfiguration<GeographicRegion>
    {
        public GeographicRegionMap()
        {
            // Primary Key
            HasKey(t => t.GeographicRegionId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("GeographicRegion", "Geographic");
            Property(t => t.GeographicRegionId).HasColumnName("GeographicRegionID");
            Property(t => t.GeographicCountryId).HasColumnName("GeographicCountryID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.GeographicCountry)
                .WithMany(t => t.GeographicRegions)
                .HasForeignKey(d => d.GeographicCountryId);

        }
    }
}
