using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            HasKey(t => t.RegionId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.Code)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Region", "Client");
            Property(t => t.RegionId).HasColumnName("RegionID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.RegionStatusId).HasColumnName("RegionStatusID");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.RegionGroupId).HasColumnName("RegionGroupID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.Code).HasColumnName("Code");

            // Relationships
            HasOptional(t => t.RegionGroup)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.RegionGroupId);
            HasRequired(t => t.RegionStatus)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.RegionStatusId);

        }
    }
}
