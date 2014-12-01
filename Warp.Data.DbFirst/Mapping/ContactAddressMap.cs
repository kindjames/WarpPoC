using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressMap : EntityTypeConfiguration<ContactAddress>
    {
        public ContactAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressId);

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
            this.ToTable("ContactAddress", "Geographic");
            this.Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Address3).HasColumnName("Address3");
            this.Property(t => t.Address4).HasColumnName("Address4");
            this.Property(t => t.Address5).HasColumnName("Address5");
            this.Property(t => t.Postcode).HasColumnName("Postcode");
            this.Property(t => t.GeographicPostcodeId).HasColumnName("GeographicPostcodeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
