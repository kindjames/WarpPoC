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
            HasKey(t => t.SimpleVisitQuestionResultId);

            // Properties
            Property(t => t.SimpleVisitQuestionResultId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("SimpleVisitQuestionResult");
            Property(t => t.SimpleVisitQuestionResultId).HasColumnName("SimpleVisitQuestionResultID");
            Property(t => t.SimpleVisitId).HasColumnName("SimpleVisitID");
            Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.PossibleAnswerId);
            HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.QuestionnaireQuestionId);
            HasRequired(t => t.SimpleVisit)
                .WithMany(t => t.SimpleVisitQuestionResults)
                .HasForeignKey(d => d.SimpleVisitId);

        }
    }
}
