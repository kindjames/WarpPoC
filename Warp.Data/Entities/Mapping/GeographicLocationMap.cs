using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
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
            this.ToTable("GeographicLocation", "Geographic");
            this.Property(t => t.GeographicLocationID).HasColumnName("GeographicLocationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
