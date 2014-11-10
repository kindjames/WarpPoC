using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ContactAddressGeoLocationMap : EntityTypeConfiguration<ContactAddressGeoLocation>
    {
        public ContactAddressGeoLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressGeoLocationID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressGeoLocation", "Geographic");
            this.Property(t => t.ContactAddressGeoLocationID).HasColumnName("ContactAddressGeoLocationID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.GeographicLocationID).HasColumnName("GeographicLocationID");
            this.Property(t => t.GeocodeX).HasColumnName("GeocodeX");
            this.Property(t => t.GeocodeY).HasColumnName("GeocodeY");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressGeoLocations)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasOptional(t => t.GeographicLocation)
                .WithMany(t => t.ContactAddressGeoLocations)
                .HasForeignKey(d => d.GeographicLocationID);

        }
    }
}
