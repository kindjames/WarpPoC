using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefBranchMap : EntityTypeConfiguration<BriefBranch>
    {
        public BriefBranchMap()
        {
            // Primary Key
            HasKey(t => t.BriefBranchId);

            // Properties
            Property(t => t.BriefBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BriefBranch");
            Property(t => t.BriefBranchId).HasColumnName("BriefBranchID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.BriefId).HasColumnName("BriefID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BriefBranches)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.Brief)
                .WithMany(t => t.BriefBranches)
                .HasForeignKey(d => d.BriefId);

        }
    }
}
