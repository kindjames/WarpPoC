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

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RegionHistory", "Client");
            this.Property(t => t.RegionHistoryID).HasColumnName("RegionHistoryID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.RegionName).HasColumnName("RegionName");
            this.Property(t => t.RegionStatusID).HasColumnName("RegionStatusID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.EnteredByUserRoleID).HasColumnName("EnteredByUserRoleID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Code).HasColumnName("Code");

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
