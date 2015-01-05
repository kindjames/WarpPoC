using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class GeographicPostalAreaMap : EntityTypeConfiguration<GeographicPostalArea>
    {
        public GeographicPostalAreaMap()
        {
            // Primary Key
            HasKey(t => t.GeographicPostalAreaId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("GeographicPostalArea", "Geographic");
            Property(t => t.GeographicPostalAreaId).HasColumnName("GeographicPostalAreaID");
            Property(t => t.GeographicLocationId).HasColumnName("GeographicLocationID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
