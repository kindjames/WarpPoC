using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AssessmentAreaBranchMap : EntityTypeConfiguration<AssessmentAreaBranch>
    {
        public AssessmentAreaBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessmentAreaBranchID);

            // Properties
            this.Property(t => t.AssessmentAreaBranchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessmentAreaBranch");
            this.Property(t => t.AssessmentAreaBranchID).HasColumnName("AssessmentAreaBranchID");
            this.Property(t => t.AssessmentAreaID).HasColumnName("AssessmentAreaID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.AssessmentAreaBranches)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.AssessmentAreaBranches)
                .HasForeignKey(d => d.AssessmentAreaID);

        }
    }
}
