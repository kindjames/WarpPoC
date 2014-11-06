using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchLegacyUserMap : EntityTypeConfiguration<BranchLegacyUser>
    {
        public BranchLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchLegacyID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BranchLegacyUser", "Migration");
            this.Property(t => t.BranchLegacyID).HasColumnName("BranchLegacyID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.LegacyID).HasColumnName("LegacyID");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchLegacyUsers)
                .HasForeignKey(d => d.BranchID);

        }
    }
}
