using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SimpleVisitQuestionResultMap : EntityTypeConfiguration<SimpleVisitQuestionResult>
    {
        public SimpleVisitQuestionResultMap()
        {
            // Primary Key
            this.HasKey(t => t.SimpleVisitQuestionResultID);

            // Properties
            this.Property(t => t.SimpleVisitQuestionResultID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SimpleVisitQuestionResult");
            this.Property(t => t.SimpleVisitQuestionResultID).HasColumnName("SimpleVisitQuestionResultID");
            this.Property(t => t.SimpleVisitID).HasColumnName("SimpleVisitID");
            this.Property(t => t.QuestionnaireQuestionID).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.PossibleAnswerID);
            this.HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.QuestionnaireQuestionID);
            this.HasRequired(t => t.SimpleVisit)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.SimpleVisitID);

        }
    }
}
