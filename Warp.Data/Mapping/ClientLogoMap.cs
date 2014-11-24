using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientLogoMap : EntityTypeConfiguration<ClientLogo>
    {
        public ClientLogoMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientLogoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientLogo", "Client");
            this.Property(t => t.ClientLogoId).HasColumnName("ClientLogoID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.LogoId).HasColumnName("LogoID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Logo)
                .WithMany(t => t.ClientLogoes)
                .HasForeignKey(d => d.LogoId);

        }
    }
}
