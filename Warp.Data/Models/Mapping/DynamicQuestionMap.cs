using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class DynamicQuestionMap : EntityTypeConfiguration<DynamicQuestion>
    {
        public DynamicQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.DynamicQuestionID);

            // Properties
            this.Property(t => t.DynamicQuestionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DynamicQuestion");
            this.Property(t => t.DynamicQuestionID).HasColumnName("DynamicQuestionID");
            this.Property(t => t.MasterQuestionnaireQuestionID).HasColumnName("MasterQuestionnaireQuestionID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.ChildQuestionnaireQuestionID).HasColumnName("ChildQuestionnaireQuestionID");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.DynamicQuestions)
                .HasForeignKey(d => d.PossibleAnswerID);
            this.HasOptional(t => t.QuestionnaireQuestion)
                .WithMany(t => t.DynamicQuestions)
                .HasForeignKey(d => d.ChildQuestionnaireQuestionID);
            this.HasRequired(t => t.QuestionnaireQuestion1)
                .WithMany(t => t.DynamicQuestions1)
                .HasForeignKey(d => d.MasterQuestionnaireQuestionID);

        }
    }
}
