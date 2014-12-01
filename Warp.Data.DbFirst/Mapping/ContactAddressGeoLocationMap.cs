using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressGeoLocationMap : EntityTypeConfiguration<ContactAddressGeoLocation>
    {
        public ContactAddressGeoLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressGeoLocationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressGeoLocation", "Geographic");
            this.Property(t => t.ContactAddressGeoLocationId).HasColumnName("ContactAddressGeoLocationID");
            this.Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            this.Property(t => t.GeographicLocationId).HasColumnName("GeographicLocationID");
            this.Property(t => t.GeocodeX).HasColumnName("GeocodeX");
            this.Property(t => t.GeocodeY).HasColumnName("GeocodeY");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressGeoLocations)
                .HasForeignKey(d => d.ContactAddressId);
            this.HasOptional(t => t.GeographicLocation)
                .WithMany(t => t.ContactAddressGeoLocations)
                .HasForeignKey(d => d.GeographicLocationId);

        }
    }
}
