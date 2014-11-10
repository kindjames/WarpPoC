using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
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
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
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
