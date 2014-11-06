using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchLogoMap : EntityTypeConfiguration<BranchLogo>
    {
        public BranchLogoMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchLogoID);

            // Properties
            this.Property(t => t.LogoPath)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("BranchLogo", "Client");
            this.Property(t => t.BranchLogoID).HasColumnName("BranchLogoID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.LogoPath).HasColumnName("LogoPath");
        }
    }
}
