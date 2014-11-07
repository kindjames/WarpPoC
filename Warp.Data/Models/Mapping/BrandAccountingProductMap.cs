using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BrandAccountingProductMap : EntityTypeConfiguration<BrandAccountingProduct>
    {
        public BrandAccountingProductMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandAccountingProductID);

            // Properties
            this.Property(t => t.BrandAccountingProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BrandAccountingProduct");
            this.Property(t => t.BrandAccountingProductID).HasColumnName("BrandAccountingProductID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.AccountingProductID).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowID).HasColumnName("KashFlowID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandAccountingProducts)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.BrandAccountingProducts)
                .HasForeignKey(d => d.AccountingProductID);

        }
    }
}
