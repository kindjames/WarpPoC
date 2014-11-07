using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BriefBranchMap : EntityTypeConfiguration<BriefBranch>
    {
        public BriefBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefBranchID);

            // Properties
            this.Property(t => t.BriefBranchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefBranch");
            this.Property(t => t.BriefBranchID).HasColumnName("BriefBranchID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.BriefID).HasColumnName("BriefID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BriefBranches)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefBranches)
                .HasForeignKey(d => d.BriefID);

        }
    }
}
