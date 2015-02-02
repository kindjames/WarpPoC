using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientLogoMap : EntityTypeConfiguration<ClientLogo>
    {
        public ClientLogoMap()
        {
            // Primary Key
            HasKey(t => t.ClientLogoId);

            // Properties
            // Table & Column Mappings
            ToTable("ClientLogo", "Client");
            Property(t => t.ClientLogoId).HasColumnName("ClientLogoID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.LogoId).HasColumnName("LogoID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Logo)
                .WithMany(t => t.ClientLogoes)
                .HasForeignKey(d => d.LogoId);

        }
    }
}
