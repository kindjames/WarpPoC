using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchSocialNetworkMap : EntityTypeConfiguration<BranchSocialNetwork>
    {
        public BranchSocialNetworkMap()
        {
            // Primary Key
            HasKey(t => t.BranchSocialNetworkId);

            // Properties
            Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("BranchSocialNetwork", "Social");
            Property(t => t.BranchSocialNetworkId).HasColumnName("BranchSocialNetworkID");
            Property(t => t.SocialNetworkId).HasColumnName("SocialNetworkID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Value).HasColumnName("Value");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BranchSocialNetworks)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.BranchSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkId);

        }
    }
}
