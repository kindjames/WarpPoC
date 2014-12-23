using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class GeographicCountyMap : EntityTypeConfiguration<GeographicCounty>
    {
        public GeographicCountyMap()
        {
            // Primary Key
            HasKey(t => t.GeographicCountyId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("GeographicCounty", "Geographic");
            Property(t => t.GeographicCountyId).HasColumnName("GeographicCountyID");
            Property(t => t.GeographicRegionId).HasColumnName("GeographicRegionID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.GeographicRegion)
                .WithMany(t => t.GeographicCounties)
                .HasForeignKey(d => d.GeographicRegionId);

        }
    }
}
