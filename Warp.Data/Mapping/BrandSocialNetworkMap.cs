using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BrandSocialNetworkMap : EntityTypeConfiguration<BrandSocialNetwork>
    {
        public BrandSocialNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandSocialNetworkId);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BrandSocialNetwork", "Social");
            this.Property(t => t.BrandSocialNetworkId).HasColumnName("BrandSocialNetworkID");
            this.Property(t => t.SocialNetworkId).HasColumnName("SocialNetworkID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandSocialNetworks)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.BrandSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkId);

        }
    }
}
