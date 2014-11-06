using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchSocialNetworkMap : EntityTypeConfiguration<BranchSocialNetwork>
    {
        public BranchSocialNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchSocialNetworkID);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BranchSocialNetwork", "Social");
            this.Property(t => t.BranchSocialNetworkID).HasColumnName("BranchSocialNetworkID");
            this.Property(t => t.SocialNetworkID).HasColumnName("SocialNetworkID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchSocialNetworks)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.BranchSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkID);

        }
    }
}
