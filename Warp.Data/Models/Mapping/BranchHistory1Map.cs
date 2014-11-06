using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchHistory1Map : EntityTypeConfiguration<BranchHistory1>
    {
        public BranchHistory1Map()
        {
            // Primary Key
            this.HasKey(t => t.BranchHistoryID);

            // Properties
            this.Property(t => t.BranchHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BranchHistory");
            this.Property(t => t.BranchHistoryID).HasColumnName("BranchHistoryID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.BranchStatusID).HasColumnName("BranchStatusID");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.Notes).HasColumnName("Notes");

            // Relationships
            this.HasRequired(t => t.Branch1)
                .WithMany(t => t.BranchHistory1)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.BranchStatus1)
                .WithMany(t => t.BranchHistory1)
                .HasForeignKey(d => d.BranchStatusID);

        }
    }
}
