using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchLogoMap : EntityTypeConfiguration<BranchLogo>
    {
        public BranchLogoMap()
        {
            // Primary Key
            HasKey(t => t.BranchLogoId);

            // Properties
            // Table & Column Mappings
            ToTable("BranchLogo", "Client");
            Property(t => t.BranchLogoId).HasColumnName("BranchLogoID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.LogoId).HasColumnName("LogoID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Logo)
                .WithMany(t => t.BranchLogoes)
                .HasForeignKey(d => d.LogoId);

        }
    }
}
