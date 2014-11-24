using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class GeographicPostalAreaMap : EntityTypeConfiguration<GeographicPostalArea>
    {
        public GeographicPostalAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicPostalAreaId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicPostalArea", "Geographic");
            this.Property(t => t.GeographicPostalAreaId).HasColumnName("GeographicPostalAreaID");
            this.Property(t => t.GeographicLocationId).HasColumnName("GeographicLocationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
