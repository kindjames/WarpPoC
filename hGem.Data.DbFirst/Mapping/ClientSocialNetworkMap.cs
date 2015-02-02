using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientSocialNetworkMap : EntityTypeConfiguration<ClientSocialNetwork>
    {
        public ClientSocialNetworkMap()
        {
            // Primary Key
            HasKey(t => t.ClientSocialNetworkId);

            // Properties
            Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("ClientSocialNetwork", "Social");
            Property(t => t.ClientSocialNetworkId).HasColumnName("ClientSocialNetworkID");
            Property(t => t.SocialNetworkId).HasColumnName("SocialNetworkID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Value).HasColumnName("Value");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientSocialNetworks)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.ClientSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkId);

        }
    }
}
