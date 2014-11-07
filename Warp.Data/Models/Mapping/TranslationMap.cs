using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TranslationMap : EntityTypeConfiguration<Translation>
    {
        public TranslationMap()
        {
            // Primary Key
            this.HasKey(t => t.TranslationID);

            // Properties
            this.Property(t => t.TranslationString)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Translation", "Translation");
            this.Property(t => t.TranslationID).HasColumnName("TranslationID");
            this.Property(t => t.CodeResourceID).HasColumnName("CodeResourceID");
            this.Property(t => t.ApplicationLanguageID).HasColumnName("ApplicationLanguageID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.TranslationString).HasColumnName("TranslationString");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.ApplicationLanguage)
                .WithMany(t => t.Translations)
                .HasForeignKey(d => d.ApplicationLanguageID);
            this.HasRequired(t => t.CodeResource)
                .WithMany(t => t.Translations)
                .HasForeignKey(d => d.CodeResourceID);

        }
    }
}
