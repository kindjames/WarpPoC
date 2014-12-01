using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ApplicationLanguageMap : EntityTypeConfiguration<ApplicationLanguage>
    {
        public ApplicationLanguageMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicationLanguageId);

            // Properties
            this.Property(t => t.NeutralCulture)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Locale)
                .HasMaxLength(50);

            this.Property(t => t.Culture)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DisplayName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ApplicationLanguage", "Translation");
            this.Property(t => t.ApplicationLanguageId).HasColumnName("ApplicationLanguageID");
            this.Property(t => t.NeutralCulture).HasColumnName("NeutralCulture");
            this.Property(t => t.Locale).HasColumnName("Locale");
            this.Property(t => t.Culture).HasColumnName("Culture");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
