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
            HasKey(t => t.ClientAccountingProductId);

            // Properties
            Property(t => t.ClientAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ClientAccountingProduct");
            Property(t => t.ClientAccountingProductId).HasColumnName("ClientAccountingProductID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientAccountingProducts)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.ClientAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);

        }
    }
}
