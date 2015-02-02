using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandSocialNetworkMap : EntityTypeConfiguration<BrandSocialNetwork>
    {
        public BrandSocialNetworkMap()
        {
            // Primary Key
            HasKey(t => t.BrandSocialNetworkId);

            // Properties
            Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("BrandSocialNetwork", "Social");
            Property(t => t.BrandSocialNetworkId).HasColumnName("BrandSocialNetworkID");
            Property(t => t.SocialNetworkId).HasColumnName("SocialNetworkID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Value).HasColumnName("Value");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BrandSocialNetworks)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.BrandSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkId);

        }
    }
}
