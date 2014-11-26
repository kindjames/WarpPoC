using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TranslationMap : EntityTypeConfiguration<Translation>
    {
        public TranslationMap()
        {
            // Primary Key
            this.HasKey(t => t.TranslationId);

            // Properties
            this.Property(t => t.TranslationString)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Translation", "Translation");
            this.Property(t => t.TranslationId).HasColumnName("TranslationID");
            this.Property(t => t.CodeResourceId).HasColumnName("CodeResourceID");
            this.Property(t => t.ApplicationLanguageId).HasColumnName("ApplicationLanguageID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.TranslationString).HasColumnName("TranslationString");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.ApplicationLanguage)
                .WithMany(t => t.Translations)
                .HasForeignKey(d => d.ApplicationLanguageId);
            this.HasRequired(t => t.CodeResource)
                .WithMany(t => t.Translations)
                .HasForeignKey(d => d.CodeResourceId);

        }
    }
}
