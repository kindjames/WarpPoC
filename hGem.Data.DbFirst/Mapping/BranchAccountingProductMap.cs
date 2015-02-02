using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchAccountingProductMap : EntityTypeConfiguration<BranchAccountingProduct>
    {
        public BranchAccountingProductMap()
        {
            // Primary Key
            HasKey(t => t.BranchAccountingProductId);

            // Properties
            Property(t => t.BranchAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BranchAccountingProduct");
            Property(t => t.BranchAccountingProductId).HasColumnName("BranchAccountingProductID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BranchAccountingProducts)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.BranchAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);

        }
    }
}
