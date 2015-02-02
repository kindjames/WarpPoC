using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientLegacyUserMap : EntityTypeConfiguration<ClientLegacyUser>
    {
        public ClientLegacyUserMap()
        {
            // Primary Key
            HasKey(t => t.ClientLegacyId);

            // Properties
            // Table & Column Mappings
            ToTable("ClientLegacyUser", "Migration");
            Property(t => t.ClientLegacyId).HasColumnName("ClientLegacyID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.LegacyId).HasColumnName("LegacyID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientLegacyUsers)
                .HasForeignKey(d => d.ClientId);
        }
    }
}