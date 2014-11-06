using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonBrandMap : EntityTypeConfiguration<PersonBrand>
    {
        public PersonBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonBrandID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonBrand");
            this.Property(t => t.PersonBrandID).HasColumnName("PersonBrandID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.PersonBrands)
                .HasForeignKey(d => d.BrandID);

        }
    }
}
