using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandQuestionnaireMap : EntityTypeConfiguration<BrandQuestionnaire>
    {
        public BrandQuestionnaireMap()
        {
            // Primary Key
            HasKey(t => t.BrandQuestionnaireId);

            // Properties
            Property(t => t.BrandQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BrandQuestionnaire");
            Property(t => t.BrandQuestionnaireId).HasColumnName("BrandQuestionnaireID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
