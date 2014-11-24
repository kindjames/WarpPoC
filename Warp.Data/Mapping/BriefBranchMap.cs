using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BriefBranchMap : EntityTypeConfiguration<BriefBranch>
    {
        public BriefBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefBranchId);

            // Properties
            this.Property(t => t.BriefBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefBranch");
            this.Property(t => t.BriefBranchId).HasColumnName("BriefBranchID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.BriefId).HasColumnName("BriefID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BriefBranches)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefBranches)
                .HasForeignKey(d => d.BriefId);

        }
    }
}
