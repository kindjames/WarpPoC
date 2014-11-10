using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class SubQuestionnaireMap : EntityTypeConfiguration<SubQuestionnaire>
    {
        public SubQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.SubQuestionnaireID);

            // Properties
            this.Property(t => t.SubQuestionnaireID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SubQuestionnaire");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.SubQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireID);

        }
    }
}
