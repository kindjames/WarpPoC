using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BranchHistoryMap : EntityTypeConfiguration<BranchHistory>
    {
        public BranchHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchHistoryId);

            // Properties
            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BranchHistory", "Client");
            this.Property(t => t.BranchHistoryId).HasColumnName("BranchHistoryID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.BranchStatusId).HasColumnName("BranchStatusID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchHistories)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.BranchStatus)
                .WithMany(t => t.BranchHistories)
                .HasForeignKey(d => d.BranchStatusId);

        }
    }
}
