using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RegionHistoryMap : EntityTypeConfiguration<RegionHistory>
    {
        public RegionHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionHistoryID);

            // Properties
            this.Property(t => t.RegionName)
                .HasMaxLength(150);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RegionHistory", "Client");
            this.Property(t => t.RegionHistoryID).HasColumnName("RegionHistoryID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.RegionName).HasColumnName("RegionName");
            this.Property(t => t.RegionStatusID).HasColumnName("RegionStatusID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.RegionGroupID).HasColumnName("RegionGroupID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.RegionHistories)
                .HasForeignKey(d => d.RegionID);
            this.HasRequired(t => t.RegionStatu)
                .WithMany(t => t.RegionHistories)
                .HasForeignKey(d => d.RegionStatusID);

        }
    }
}
