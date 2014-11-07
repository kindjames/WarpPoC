using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CurrencyExchangeRateMap : EntityTypeConfiguration<CurrencyExchangeRate>
    {
        public CurrencyExchangeRateMap()
        {
            // Primary Key
            this.HasKey(t => t.CurrencyExchageRateID);

            // Properties
            this.Property(t => t.CurrencyExchageRateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CurrencyExchangeRate");
            this.Property(t => t.CurrencyExchageRateID).HasColumnName("CurrencyExchageRateID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Currency)
                .WithMany(t => t.CurrencyExchangeRates)
                .HasForeignKey(d => d.CurrencyID);

        }
    }
}
