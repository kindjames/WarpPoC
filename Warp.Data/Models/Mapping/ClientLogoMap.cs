using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientLogoMap : EntityTypeConfiguration<ClientLogo>
    {
        public ClientLogoMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientLogoID);

            // Properties
            this.Property(t => t.LogoPath)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ClientLogo", "Client");
            this.Property(t => t.ClientLogoID).HasColumnName("ClientLogoID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.LogoPath).HasColumnName("LogoPath");
        }
    }
}
