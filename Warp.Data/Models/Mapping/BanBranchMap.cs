using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BanBranchMap : EntityTypeConfiguration<BanBranch>
    {
        public BanBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BanBranchID);

            // Properties
            this.Property(t => t.BanBranchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BanBranch");
            this.Property(t => t.BanBranchID).HasColumnName("BanBranchID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BanBranches)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.BanBranches)
                .HasForeignKey(d => d.AssessorID);

        }
    }
}
