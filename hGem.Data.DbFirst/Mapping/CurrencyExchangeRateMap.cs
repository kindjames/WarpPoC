using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CurrencyExchangeRateMap : EntityTypeConfiguration<CurrencyExchangeRate>
    {
        public CurrencyExchangeRateMap()
        {
            // Primary Key
            HasKey(t => t.CurrencyExchageRateId);

            // Properties
            Property(t => t.CurrencyExchageRateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("CurrencyExchangeRate");
            Property(t => t.CurrencyExchageRateId).HasColumnName("CurrencyExchageRateID");
            Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            Property(t => t.Rate).HasColumnName("Rate");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Currency)
                .WithMany(t => t.CurrencyExchangeRates)
                .HasForeignKey(d => d.CurrencyId);

        }
    }
}
