using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ContactAddressGeoLocationMap : EntityTypeConfiguration<ContactAddressGeoLocation>
    {
        public ContactAddressGeoLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressGeoLocationID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressGeoLocation", "Client");
            this.Property(t => t.ContactAddressGeoLocationID).HasColumnName("ContactAddressGeoLocationID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.GeocodeX).HasColumnName("GeocodeX");
            this.Property(t => t.GeocodeY).HasColumnName("GeocodeY");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressGeoLocations)
                .HasForeignKey(d => d.ContactAddressID);

        }
    }
}
