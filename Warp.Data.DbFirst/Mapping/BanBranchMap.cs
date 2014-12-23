using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BanBranchMap : EntityTypeConfiguration<BanBranch>
    {
        public BanBranchMap()
        {
            // Primary Key
            HasKey(t => t.BanBranchId);

            // Properties
            Property(t => t.BanBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BanBranch");
            Property(t => t.BanBranchId).HasColumnName("BanBranchID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BanBranches)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.BanBranches)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
