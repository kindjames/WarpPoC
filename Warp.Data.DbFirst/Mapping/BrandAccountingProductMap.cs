using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandAccountingProductMap : EntityTypeConfiguration<BrandAccountingProduct>
    {
        public BrandAccountingProductMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandAccountingProductId);

            // Properties
            this.Property(t => t.BrandAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BrandAccountingProduct");
            this.Property(t => t.BrandAccountingProductId).HasColumnName("BrandAccountingProductID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandAccountingProducts)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.BrandAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);

        }
    }
}
