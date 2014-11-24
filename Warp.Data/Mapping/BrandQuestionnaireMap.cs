using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BrandQuestionnaireMap : EntityTypeConfiguration<BrandQuestionnaire>
    {
        public BrandQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandQuestionnaireId);

            // Properties
            this.Property(t => t.BrandQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BrandQuestionnaire");
            this.Property(t => t.BrandQuestionnaireId).HasColumnName("BrandQuestionnaireID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
