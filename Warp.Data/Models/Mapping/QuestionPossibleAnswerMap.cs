using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionPossibleAnswerMap : EntityTypeConfiguration<QuestionPossibleAnswer>
    {
        public QuestionPossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionPossibleAnswerID);

            // Properties
            this.Property(t => t.QuestionPossibleAnswerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionPossibleAnswer");
            this.Property(t => t.QuestionPossibleAnswerID).HasColumnName("QuestionPossibleAnswerID");
            this.Property(t => t.QuestionID).HasColumnName("QuestionID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.QuestionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerID);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionPossibleAnswers)
                .HasForeignKey(d => d.QuestionID);

        }
    }
}
