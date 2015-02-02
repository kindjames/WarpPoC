using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientOrganisationMap : EntityTypeConfiguration<ClientOrganisation>
    {
        public ClientOrganisationMap()
        {
            // Primary Key
            HasKey(t => t.ClientOrganisationId);

            // Properties
            // Table & Column Mappings
            ToTable("ClientOrganisation", "Client");
            Property(t => t.ClientOrganisationId).HasColumnName("ClientOrganisationID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.RegionActive).HasColumnName("RegionActive");
            Property(t => t.AreaActive).HasColumnName("AreaActive");
            Property(t => t.BrandLevel).HasColumnName("BrandLevel");
            Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            Property(t => t.Created).HasColumnName("Created");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.BrandActive).HasColumnName("BrandActive");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientOrganisations)
                .HasForeignKey(d => d.ClientId);

        }
    }
}
