using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchLogoMap : EntityTypeConfiguration<BranchLogo>
    {
        public BranchLogoMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchLogoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("BranchLogo", "Client");
            this.Property(t => t.BranchLogoId).HasColumnName("BranchLogoID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.LogoId).HasColumnName("LogoID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Logo)
                .WithMany(t => t.BranchLogoes)
                .HasForeignKey(d => d.LogoId);

        }
    }
}
