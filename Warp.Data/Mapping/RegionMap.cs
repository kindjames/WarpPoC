using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Code)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Region", "Client");
            this.Property(t => t.RegionId).HasColumnName("RegionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.RegionStatusId).HasColumnName("RegionStatusID");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.RegionGroupId).HasColumnName("RegionGroupID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Code).HasColumnName("Code");

            // Relationships
            this.HasOptional(t => t.RegionGroup)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.RegionGroupId);
            this.HasRequired(t => t.RegionStatu)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.RegionStatusId);

        }
    }
}
