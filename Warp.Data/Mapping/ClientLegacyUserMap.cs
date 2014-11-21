using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientLegacyUserMap : EntityTypeConfiguration<ClientLegacyUser>
    {
        public ClientLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientLegacyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientLegacyUser", "Migration");
            this.Property(t => t.ClientLegacyId).HasColumnName("ClientLegacyID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.LegacyId).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientLegacyUsers)
                .HasForeignKey(d => d.ClientId);
        }
    }
}