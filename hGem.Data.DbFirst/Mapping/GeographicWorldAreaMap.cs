using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class GeographicWorldAreaMap : EntityTypeConfiguration<GeographicWorldArea>
    {
        public GeographicWorldAreaMap()
        {
            // Primary Key
            HasKey(t => t.GeographicWorldAreaId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.DefaultLocalisation)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("GeographicWorldArea", "Geographic");
            Property(t => t.GeographicWorldAreaId).HasColumnName("GeographicWorldAreaID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DefaultLocalisation).HasColumnName("DefaultLocalisation");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
