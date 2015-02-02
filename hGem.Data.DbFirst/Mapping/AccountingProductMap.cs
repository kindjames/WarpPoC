using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AccountingProductMap : EntityTypeConfiguration<AccountingProduct>
    {
        public AccountingProductMap()
        {
            // Primary Key
            HasKey(t => t.AccountingProductId);

            // Properties
            Property(t => t.AccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("AccountingProduct");
            Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
