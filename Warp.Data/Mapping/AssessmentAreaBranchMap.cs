using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessmentAreaBranchMap : EntityTypeConfiguration<AssessmentAreaBranch>
    {
        public AssessmentAreaBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessmentAreaBranchId);

            // Properties
            this.Property(t => t.AssessmentAreaBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessmentAreaBranch");
            this.Property(t => t.AssessmentAreaBranchId).HasColumnName("AssessmentAreaBranchID");
            this.Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.AssessmentAreaBranches)
                .HasForeignKey(d => d.BranchId);

            this.HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.AssessmentAreaBranches)
                .HasForeignKey(d => d.AssessmentAreaId);

        }
    }
}
