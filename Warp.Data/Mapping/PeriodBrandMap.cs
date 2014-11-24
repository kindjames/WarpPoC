using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PeriodBrandMap : EntityTypeConfiguration<PeriodBrand>
    {
        public PeriodBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodBrandId);

            // Properties
            this.Property(t => t.PeriodBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PeriodBrand");
            this.Property(t => t.PeriodBrandId).HasColumnName("PeriodBrandID");
            this.Property(t => t.PeriodId).HasColumnName("PeriodID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.PeriodBrands)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.Period)
                .WithMany(t => t.PeriodBrands)
                .HasForeignKey(d => d.PeriodId);

        }
    }
}
