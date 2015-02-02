using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubQuestionnaireMap : EntityTypeConfiguration<SubQuestionnaire>
    {
        public SubQuestionnaireMap()
        {
            // Primary Key
            HasKey(t => t.SubQuestionnaireId);

            // Properties
            Property(t => t.SubQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("SubQuestionnaire");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.SubQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);

        }
    }
}
