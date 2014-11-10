using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class GeographicCountryMap : EntityTypeConfiguration<GeographicCountry>
    {
        public GeographicCountryMap()
        {
            // Primary Key
            this.HasKey(t => t.GeographicCountryID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeographicCountry", "Geographic");
            this.Property(t => t.GeographicCountryID).HasColumnName("GeographicCountryID");
            this.Property(t => t.GeographicWorldAreaID).HasColumnName("GeographicWorldAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Currency)
                .WithMany(t => t.GeographicCountries)
                .HasForeignKey(d => d.CurrencyID);
            this.HasRequired(t => t.GeographicWorldArea)
                .WithMany(t => t.GeographicCountries)
                .HasForeignKey(d => d.GeographicWorldAreaID);

        }
    }
}
