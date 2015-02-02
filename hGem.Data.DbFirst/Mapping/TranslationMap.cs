using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TranslationMap : EntityTypeConfiguration<Translation>
    {
        public TranslationMap()
        {
            // Primary Key
            HasKey(t => t.TranslationId);

            // Properties
            Property(t => t.TranslationString)
                .IsRequired();

            // Table & Column Mappings
            ToTable("Translation", "Translation");
            Property(t => t.TranslationId).HasColumnName("TranslationID");
            Property(t => t.CodeResourceId).HasColumnName("CodeResourceID");
            Property(t => t.ApplicationLanguageId).HasColumnName("ApplicationLanguageID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.TranslationString).HasColumnName("TranslationString");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.ApplicationLanguage)
                .WithMany(t => t.Translations)
                .HasForeignKey(d => d.ApplicationLanguageId);
            HasRequired(t => t.CodeResource)
                .WithMany(t => t.Translations)
                .HasForeignKey(d => d.CodeResourceId);

        }
    }
}
