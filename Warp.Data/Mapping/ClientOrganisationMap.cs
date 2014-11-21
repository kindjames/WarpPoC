using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientOrganisationMap : EntityTypeConfiguration<ClientOrganisation>
    {
        public ClientOrganisationMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientOrganisationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientOrganisation", "Client");
            this.Property(t => t.ClientOrganisationId).HasColumnName("ClientOrganisationID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.RegionActive).HasColumnName("RegionActive");
            this.Property(t => t.AreaActive).HasColumnName("AreaActive");
            this.Property(t => t.BrandLevel).HasColumnName("BrandLevel");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.BrandActive).HasColumnName("BrandActive");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientOrganisations)
                .HasForeignKey(d => d.ClientId);

        }
    }
}
