using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ApplicationLanguageMap : EntityTypeConfiguration<ApplicationLanguage>
    {
        public ApplicationLanguageMap()
        {
            // Primary Key
            HasKey(t => t.ApplicationLanguageId);

            // Properties
            Property(t => t.NeutralCulture)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Locale)
                .HasMaxLength(50);

            Property(t => t.Culture)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.DisplayName)
                .IsRequired();

            // Table & Column Mappings
            ToTable("ApplicationLanguage", "Translation");
            Property(t => t.ApplicationLanguageId).HasColumnName("ApplicationLanguageID");
            Property(t => t.NeutralCulture).HasColumnName("NeutralCulture");
            Property(t => t.Locale).HasColumnName("Locale");
            Property(t => t.Culture).HasColumnName("Culture");
            Property(t => t.DisplayName).HasColumnName("DisplayName");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
