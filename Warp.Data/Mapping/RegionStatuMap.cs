using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class RegionStatusMap : EntityTypeConfiguration<RegionStatus>
    {
        public RegionStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionStatusId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RegionStatus", "Client");
            this.Property(t => t.RegionStatusId).HasColumnName("RegionStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
