using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Code)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Region", "Client");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.RegionStatusID).HasColumnName("RegionStatusID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.RegionGroupID).HasColumnName("RegionGroupID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Code).HasColumnName("Code");

            // Relationships
            this.HasOptional(t => t.RegionGroup)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.RegionGroupID);
            this.HasRequired(t => t.RegionStatu)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.RegionStatusID);

        }
    }
}
