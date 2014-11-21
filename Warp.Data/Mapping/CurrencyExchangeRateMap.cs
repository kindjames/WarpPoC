using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CurrencyExchangeRateMap : EntityTypeConfiguration<CurrencyExchangeRate>
    {
        public CurrencyExchangeRateMap()
        {
            // Primary Key
            this.HasKey(t => t.CurrencyExchageRateId);

            // Properties
            this.Property(t => t.CurrencyExchageRateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CurrencyExchangeRate");
            this.Property(t => t.CurrencyExchageRateId).HasColumnName("CurrencyExchageRateID");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Currency)
                .WithMany(t => t.CurrencyExchangeRates)
                .HasForeignKey(d => d.CurrencyId);

        }
    }
}
