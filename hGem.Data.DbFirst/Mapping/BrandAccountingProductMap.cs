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
            HasKey(t => t.BrandAccountingProductId);

            // Properties
            Property(t => t.BrandAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BrandAccountingProduct");
            Property(t => t.BrandAccountingProductId).HasColumnName("BrandAccountingProductID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BrandAccountingProducts)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.BrandAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);

        }
    }
}
