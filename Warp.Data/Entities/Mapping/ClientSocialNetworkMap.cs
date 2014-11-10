using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ClientSocialNetworkMap : EntityTypeConfiguration<ClientSocialNetwork>
    {
        public ClientSocialNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientSocialNetworkID);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ClientSocialNetwork", "Social");
            this.Property(t => t.ClientSocialNetworkID).HasColumnName("ClientSocialNetworkID");
            this.Property(t => t.SocialNetworkID).HasColumnName("SocialNetworkID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientSocialNetworks)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.SocialNetwork)
                .WithMany(t => t.ClientSocialNetworks)
                .HasForeignKey(d => d.SocialNetworkID);

        }
    }
}
