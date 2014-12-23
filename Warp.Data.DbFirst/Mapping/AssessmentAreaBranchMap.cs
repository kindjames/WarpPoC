using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessmentAreaBranchMap : EntityTypeConfiguration<AssessmentAreaBranch>
    {
        public AssessmentAreaBranchMap()
        {
            // Primary Key
            HasKey(t => t.AssessmentAreaBranchId);

            // Properties
            Property(t => t.AssessmentAreaBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessmentAreaBranch");
            Property(t => t.AssessmentAreaBranchId).HasColumnName("AssessmentAreaBranchID");
            Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.AssessmentAreaBranches)
                .HasForeignKey(d => d.BranchId);

            HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.AssessmentAreaBranches)
                .HasForeignKey(d => d.AssessmentAreaId);

        }
    }
}
