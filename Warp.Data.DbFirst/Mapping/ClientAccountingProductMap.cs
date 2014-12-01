using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientAccountingProductMap : EntityTypeConfiguration<ClientAccountingProduct>
    {
        public ClientAccountingProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientAccountingProductId);

            // Properties
            this.Property(t => t.ClientAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientAccountingProduct");
            this.Property(t => t.ClientAccountingProductId).HasColumnName("ClientAccountingProductID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientAccountingProducts)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.ClientAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);

        }
    }
}
