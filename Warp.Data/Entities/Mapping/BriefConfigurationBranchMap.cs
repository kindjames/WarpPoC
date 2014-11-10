using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BriefConfigurationBranchMap : EntityTypeConfiguration<BriefConfigurationBranch>
    {
        public BriefConfigurationBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefConfigurationBranchID);

            // Properties
            this.Property(t => t.BriefConfigurationBranchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefConfigurationBranch");
            this.Property(t => t.BriefConfigurationBranchID).HasColumnName("BriefConfigurationBranchID");
            this.Property(t => t.BriefConfigurationID).HasColumnName("BriefConfigurationID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BriefConfigurationBranches)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.BriefConfiguration)
                .WithMany(t => t.BriefConfigurationBranches)
                .HasForeignKey(d => d.BriefConfigurationID);

        }
    }
}
