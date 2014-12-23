using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchLegacyUserMap : EntityTypeConfiguration<BranchLegacyUser>
    {
        public BranchLegacyUserMap()
        {
            // Primary Key
            HasKey(t => t.BranchLegacyId);

            // Properties
            // Table & Column Mappings
            ToTable("BranchLegacyUser", "Migration");
            Property(t => t.BranchLegacyId).HasColumnName("BranchLegacyID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.LegacyId).HasColumnName("LegacyID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BranchLegacyUsers)
                .HasForeignKey(d => d.BranchId);

        }
    }
}
