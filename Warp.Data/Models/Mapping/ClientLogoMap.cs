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
            // Table & Column Mappings
            this.ToTable("ClientLogo", "Client");
            this.Property(t => t.ClientLogoID).HasColumnName("ClientLogoID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.LogoID).HasColumnName("LogoID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Logo)
                .WithMany(t => t.ClientLogoes)
                .HasForeignKey(d => d.LogoID);

        }
    }
}
