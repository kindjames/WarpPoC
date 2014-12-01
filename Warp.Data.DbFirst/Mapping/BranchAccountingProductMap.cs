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
            this.HasKey(t => t.BranchAccountingProductId);

            // Properties
            this.Property(t => t.BranchAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BranchAccountingProduct");
            this.Property(t => t.BranchAccountingProductId).HasColumnName("BranchAccountingProductID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchAccountingProducts)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.BranchAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);

        }
    }
}
