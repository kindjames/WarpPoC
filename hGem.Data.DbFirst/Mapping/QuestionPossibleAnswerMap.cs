using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionPossibleAnswerMap : EntityTypeConfiguration<QuestionPossibleAnswer>
    {
        public QuestionPossibleAnswerMap()
        {
            // Primary Key
            HasKey(t => t.QuestionPossibleAnswerId);

            // Properties
            Property(t => t.QuestionPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("QuestionPossibleAnswer");
            Property(t => t.QuestionPossibleAnswerId).HasColumnName("QuestionPossibleAnswerID");
            Property(t => t.QuestionId).HasColumnName("QuestionID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.QuestionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);
            HasRequired(t => t.Question)
                .WithMany(t => t.QuestionPossibleAnswers)
                .HasForeignKey(d => d.QuestionId);

        }
    }
}
