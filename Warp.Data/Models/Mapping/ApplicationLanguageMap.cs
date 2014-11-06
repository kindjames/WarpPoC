using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ApplicationLanguageMap : EntityTypeConfiguration<ApplicationLanguage>
    {
        public ApplicationLanguageMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicationLanguageId);

            // Properties
            this.Property(t => t.DisplayName)
                .IsRequired();

            this.Property(t => t.LanguageCode)
                .IsRequired();

            this.Property(t => t.FriendlyName)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ApplicationLanguage");
            this.Property(t => t.ApplicationLanguageId).HasColumnName("ApplicationLanguageId");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.LanguageCode).HasColumnName("LanguageCode");
            this.Property(t => t.FriendlyName).HasColumnName("FriendlyName");
        }
    }
}
