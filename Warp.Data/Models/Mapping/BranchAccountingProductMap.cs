using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchAccountingProductMap : EntityTypeConfiguration<BranchAccountingProduct>
    {
        public BranchAccountingProductMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchAccountingProductID);

            // Properties
            this.Property(t => t.BranchAccountingProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BranchAccountingProduct");
            this.Property(t => t.BranchAccountingProductID).HasColumnName("BranchAccountingProductID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.AccountingProductID).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowID).HasColumnName("KashFlowID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchAccountingProducts)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.BranchAccountingProducts)
                .HasForeignKey(d => d.AccountingProductID);

        }
    }
}
