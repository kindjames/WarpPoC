using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class GeographicCountryMap : EntityTypeConfiguration<GeographicCountry>
    {
        public GeographicCountryMap()
        {
            // Primary Key
            HasKey(t => t.GeographicCountryId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("GeographicCountry", "Geographic");
            Property(t => t.GeographicCountryId).HasColumnName("GeographicCountryID");
            Property(t => t.GeographicWorldAreaId).HasColumnName("GeographicWorldAreaID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Currency)
                .WithMany(t => t.GeographicCountries)
                .HasForeignKey(d => d.CurrencyId);

            HasRequired(t => t.GeographicWorldArea)
                .WithMany(t => t.GeographicCountries)
                .HasForeignKey(d => d.GeographicWorldAreaId);

        }
    }
}
