using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonBrandMap : EntityTypeConfiguration<PersonBrand>
    {
        public PersonBrandMap()
        {
            // Primary Key
            HasKey(t => t.PersonBrandId);

            // Properties
            // Table & Column Mappings
            ToTable("PersonBrand", "Client");
            Property(t => t.PersonBrandId).HasColumnName("PersonBrandID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.PersonBrands)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.Person)
                .WithMany(t => t.PersonBrands)
                .HasForeignKey(d => d.PersonId);
            HasRequired(t => t.PersonBrand2)
                .WithOptional(t => t.PersonBrand1);

        }
    }
}
