using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchSocialNetworkMap : EntityTypeConfiguration<BranchSocialNetwork>
    {
        public BranchSocialNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchSocialNetworkId);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BranchSocialNetwork", "Social");
            this.Property(t => t.BranchSocialNetworkId).HasColumnName("BranchSocialNetworkID");
            this.Property(t => t.SocialNetworkId).HasColumnName("SocialNetworkID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchSocialNetworks)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.BranchSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkId);

        }
    }
}
