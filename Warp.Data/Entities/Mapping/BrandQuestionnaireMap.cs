using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BrandQuestionnaireMap : EntityTypeConfiguration<BrandQuestionnaire>
    {
        public BrandQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandQuestionnaireID);

            // Properties
            this.Property(t => t.BrandQuestionnaireID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BrandQuestionnaire");
            this.Property(t => t.BrandQuestionnaireID).HasColumnName("BrandQuestionnaireID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.BrandQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireID);

        }
    }
}
