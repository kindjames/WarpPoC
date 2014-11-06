using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BanBrandMap : EntityTypeConfiguration<BanBrand>
    {
        public BanBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.BanBrandID);

            // Properties
            this.Property(t => t.BanBrandID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BanBrand");
            this.Property(t => t.BanBrandID).HasColumnName("BanBrandID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.AssessorID);

        }
    }
}
