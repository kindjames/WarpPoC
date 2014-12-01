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
            this.HasKey(t => t.QuestionPossibleAnswerId);

            // Properties
            this.Property(t => t.QuestionPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionPossibleAnswer");
            this.Property(t => t.QuestionPossibleAnswerId).HasColumnName("QuestionPossibleAnswerID");
            this.Property(t => t.QuestionId).HasColumnName("QuestionID");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.QuestionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionPossibleAnswers)
                .HasForeignKey(d => d.QuestionId);

        }
    }
}
