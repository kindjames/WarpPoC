using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchHistoryMap : EntityTypeConfiguration<BranchHistory>
    {
        public BranchHistoryMap()
        {
            // Primary Key
            HasKey(t => t.BranchHistoryId);

            // Properties
            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("BranchHistory", "Client");
            Property(t => t.BranchHistoryId).HasColumnName("BranchHistoryID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.BranchStatusId).HasColumnName("BranchStatusID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.Code).HasColumnName("Code");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BranchHistories)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.BranchStatus)
                .WithMany(t => t.BranchHistories)
                .HasForeignKey(d => d.BranchStatusId);

        }
    }
}
