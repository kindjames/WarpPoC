using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefConfigurationBranchMap : EntityTypeConfiguration<BriefConfigurationBranch>
    {
        public BriefConfigurationBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefConfigurationBranchId);

            // Properties
            this.Property(t => t.BriefConfigurationBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefConfigurationBranch");
            this.Property(t => t.BriefConfigurationBranchId).HasColumnName("BriefConfigurationBranchID");
            this.Property(t => t.BriefConfigurationId).HasColumnName("BriefConfigurationID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BriefConfigurationBranches)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.BriefConfiguration)
                .WithMany(t => t.BriefConfigurationBranches)
                .HasForeignKey(d => d.BriefConfigurationId);

        }
    }
}
