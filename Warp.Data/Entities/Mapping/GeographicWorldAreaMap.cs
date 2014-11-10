using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class GeographicWorldAreaMap : EntityTypeConfiguration<GeographicWorldArea>
    {
        public GeographicWorldAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicWorldAreaID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DefaultLocalisation)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("GeographicWorldArea", "Geographic");
            this.Property(t => t.GeographicWorldAreaID).HasColumnName("GeographicWorldAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DefaultLocalisation).HasColumnName("DefaultLocalisation");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
