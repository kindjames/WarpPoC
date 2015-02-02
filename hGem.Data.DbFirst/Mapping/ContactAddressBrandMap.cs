using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressBrandMap : EntityTypeConfiguration<ContactAddressBrand>
    {
        public ContactAddressBrandMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressBrandId);

            // Properties
            Property(t => t.ContactAddressBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ContactAddressBrand", "Client");
            Property(t => t.ContactAddressBrandId).HasColumnName("ContactAddressBrandID");
            Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.ContactAddressId);
            HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.ContactAddressTypeId);

        }
    }
}
