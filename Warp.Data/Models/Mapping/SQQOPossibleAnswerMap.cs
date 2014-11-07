using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SQQOPossibleAnswerMap : EntityTypeConfiguration<SQQOPossibleAnswer>
    {
        public SQQOPossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.SQQOPossibleAnswerID);

            // Properties
            this.Property(t => t.SQQOPossibleAnswerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Guidance)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SQQOPossibleAnswer");
            this.Property(t => t.SQQOPossibleAnswerID).HasColumnName("SQQOPossibleAnswerID");
            this.Property(t => t.SubQuestionnaireQuestionOverwriteID).HasColumnName("SubQuestionnaireQuestionOverwriteID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Guidance).HasColumnName("Guidance");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SQQOPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerID);
            this.HasRequired(t => t.SubQuestionnaireQuestionOverwrite)
                .WithMany(t => t.SQQOPossibleAnswers)
                .HasForeignKey(d => d.SubQuestionnaireQuestionOverwriteID);

        }
    }
}
