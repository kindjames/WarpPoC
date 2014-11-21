using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class GeographicCountryMap : EntityTypeConfiguration<GeographicCountry>
    {
        public GeographicCountryMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicCountryId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicCountry", "Geographic");
            this.Property(t => t.GeographicCountryId).HasColumnName("GeographicCountryID");
            this.Property(t => t.GeographicWorldAreaId).HasColumnName("GeographicWorldAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Currency)
                .WithMany(t => t.GeographicCountries)
                .HasForeignKey(d => d.CurrencyId);

            this.HasRequired(t => t.GeographicWorldArea)
                .WithMany(t => t.GeographicCountries)
                .HasForeignKey(d => d.GeographicWorldAreaId);

        }
    }
}
