using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressGeoLocationMap : EntityTypeConfiguration<ContactAddressGeoLocation>
    {
        public ContactAddressGeoLocationMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressGeoLocationId);

            // Properties
            // Table & Column Mappings
            ToTable("ContactAddressGeoLocation", "Geographic");
            Property(t => t.ContactAddressGeoLocationId).HasColumnName("ContactAddressGeoLocationID");
            Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            Property(t => t.GeographicLocationId).HasColumnName("GeographicLocationID");
            Property(t => t.GeocodeX).HasColumnName("GeocodeX");
            Property(t => t.GeocodeY).HasColumnName("GeocodeY");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressGeoLocations)
                .HasForeignKey(d => d.ContactAddressId);
            HasOptional(t => t.GeographicLocation)
                .WithMany(t => t.ContactAddressGeoLocations)
                .HasForeignKey(d => d.GeographicLocationId);

        }
    }
}
