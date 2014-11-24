using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SubQuestionnaireMap : EntityTypeConfiguration<SubQuestionnaire>
    {
        public SubQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.SubQuestionnaireId);

            // Properties
            this.Property(t => t.SubQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SubQuestionnaire");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.SubQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);

        }
    }
}
