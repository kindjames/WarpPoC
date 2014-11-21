using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BranchLegacyUserMap : EntityTypeConfiguration<BranchLegacyUser>
    {
        public BranchLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchLegacyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("BranchLegacyUser", "Migration");
            this.Property(t => t.BranchLegacyId).HasColumnName("BranchLegacyID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.LegacyId).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchLegacyUsers)
                .HasForeignKey(d => d.BranchId);

        }
    }
}
