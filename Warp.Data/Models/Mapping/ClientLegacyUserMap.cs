using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientLegacyUserMap : EntityTypeConfiguration<ClientLegacyUser>
    {
        public ClientLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientLegacyID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientLegacyUser", "Migration");
            this.Property(t => t.ClientLegacyID).HasColumnName("ClientLegacyID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.LegacyID).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientLegacyUsers)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
