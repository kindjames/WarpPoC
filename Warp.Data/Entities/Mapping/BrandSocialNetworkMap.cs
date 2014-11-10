using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BrandSocialNetworkMap : EntityTypeConfiguration<BrandSocialNetwork>
    {
        public BrandSocialNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandSocialNetworkID);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BrandSocialNetwork", "Social");
            this.Property(t => t.BrandSocialNetworkID).HasColumnName("BrandSocialNetworkID");
            this.Property(t => t.SocialNetworkID).HasColumnName("SocialNetworkID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandSocialNetworks)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.BrandSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkID);

        }
    }
}
