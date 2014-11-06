using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RegionGroupMap : EntityTypeConfiguration<RegionGroup>
    {
        public RegionGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionGroupID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RegionGroup", "Client");
            this.Property(t => t.RegionGroupID).HasColumnName("RegionGroupID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
