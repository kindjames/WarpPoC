using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressMap : EntityTypeConfiguration<ContactAddress>
    {
        public ContactAddressMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressId);

            // Properties
            Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Address2)
                .HasMaxLength(50);

            Property(t => t.Address3)
                .HasMaxLength(50);

            Property(t => t.Address4)
                .HasMaxLength(50);

            Property(t => t.Address5)
                .HasMaxLength(50);

            Property(t => t.Postcode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ContactAddress", "Geographic");
            Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            Property(t => t.Address1).HasColumnName("Address1");
            Property(t => t.Address2).HasColumnName("Address2");
            Property(t => t.Address3).HasColumnName("Address3");
            Property(t => t.Address4).HasColumnName("Address4");
            Property(t => t.Address5).HasColumnName("Address5");
            Property(t => t.Postcode).HasColumnName("Postcode");
            Property(t => t.GeographicPostcodeId).HasColumnName("GeographicPostcodeID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
