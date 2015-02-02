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
            HasKey(t => t.BriefConfigurationBranchId);

            // Properties
            Property(t => t.BriefConfigurationBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BriefConfigurationBranch");
            Property(t => t.BriefConfigurationBranchId).HasColumnName("BriefConfigurationBranchID");
            Property(t => t.BriefConfigurationId).HasColumnName("BriefConfigurationID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BriefConfigurationBranches)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.BriefConfiguration)
                .WithMany(t => t.BriefConfigurationBranches)
                .HasForeignKey(d => d.BriefConfigurationId);

        }
    }
}
