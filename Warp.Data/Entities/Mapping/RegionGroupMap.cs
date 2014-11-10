using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
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
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
