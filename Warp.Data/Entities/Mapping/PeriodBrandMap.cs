using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PeriodBrandMap : EntityTypeConfiguration<PeriodBrand>
    {
        public PeriodBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodBrandID);

            // Properties
            this.Property(t => t.PeriodBrandID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PeriodBrand");
            this.Property(t => t.PeriodBrandID).HasColumnName("PeriodBrandID");
            this.Property(t => t.PeriodID).HasColumnName("PeriodID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.PeriodBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Period)
                .WithMany(t => t.PeriodBrands)
                .HasForeignKey(d => d.PeriodID);

        }
    }
}
