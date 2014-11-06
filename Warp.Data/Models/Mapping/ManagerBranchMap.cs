using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerBranchMap : EntityTypeConfiguration<ManagerBranch>
    {
        public ManagerBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerBranchID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ManagerBranch");
            this.Property(t => t.ManagerBranchID).HasColumnName("ManagerBranchID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");

            // Relationships
            this.HasRequired(t => t.Branch1)
                .WithMany(t => t.ManagerBranches)
                .HasForeignKey(d => d.BranchID);

        }
    }
}
