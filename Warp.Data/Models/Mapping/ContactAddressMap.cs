using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ContactAddressMap : EntityTypeConfiguration<ContactAddress>
    {
        public ContactAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressID);

            // Properties
            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address2)
                .HasMaxLength(50);

            this.Property(t => t.Address3)
                .HasMaxLength(50);

            this.Property(t => t.Address4)
                .HasMaxLength(50);

            this.Property(t => t.Address5)
                .HasMaxLength(50);

            this.Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ContactAddress");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Address3).HasColumnName("Address3");
            this.Property(t => t.Address4).HasColumnName("Address4");
            this.Property(t => t.Address5).HasColumnName("Address5");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.GeographicPostcodeID).HasColumnName("GeographicPostcodeID");
        }
    }
}
