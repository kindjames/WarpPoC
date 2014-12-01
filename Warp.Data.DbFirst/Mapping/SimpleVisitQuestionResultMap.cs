using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SimpleVisitQuestionResultMap : EntityTypeConfiguration<SimpleVisitQuestionResult>
    {
        public SimpleVisitQuestionResultMap()
        {
            // Primary Key
            this.HasKey(t => t.SimpleVisitQuestionResultId);

            // Properties
            this.Property(t => t.SimpleVisitQuestionResultId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SimpleVisitQuestionResult");
            this.Property(t => t.SimpleVisitQuestionResultId).HasColumnName("SimpleVisitQuestionResultID");
            this.Property(t => t.SimpleVisitId).HasColumnName("SimpleVisitID");
            this.Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.PossibleAnswerId);
            this.HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.QuestionnaireQuestionId);
            this.HasRequired(t => t.SimpleVisit)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.SimpleVisitId);

        }
    }
}
