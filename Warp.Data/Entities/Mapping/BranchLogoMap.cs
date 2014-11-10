using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BranchLogoMap : EntityTypeConfiguration<BranchLogo>
    {
        public BranchLogoMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchLogoID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BranchLogo", "Client");
            this.Property(t => t.BranchLogoID).HasColumnName("BranchLogoID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.LogoID).HasColumnName("LogoID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Logo)
                .WithMany(t => t.BranchLogoes)
                .HasForeignKey(d => d.LogoID);

        }
    }
}
