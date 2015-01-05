using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class RegionGroupMap : EntityTypeConfiguration<RegionGroup>
    {
        public RegionGroupMap()
        {
            // Primary Key
            HasKey(t => t.RegionGroupId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("RegionGroup", "Client");
            Property(t => t.RegionGroupId).HasColumnName("RegionGroupID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
