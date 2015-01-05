using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SQQOPossibleAnswerMap : EntityTypeConfiguration<SQQOPossibleAnswer>
    {
        public SQQOPossibleAnswerMap()
        {
            // Primary Key
            HasKey(t => t.SQQOPossibleAnswerId);

            // Properties
            Property(t => t.SQQOPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Guidance)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("SQQOPossibleAnswer");
            Property(t => t.SQQOPossibleAnswerId).HasColumnName("SQQOPossibleAnswerID");
            Property(t => t.SubQuestionnaireQuestionOverwriteId).HasColumnName("SubQuestionnaireQuestionOverwriteID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.Guidance).HasColumnName("Guidance");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SQQOPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);
            HasRequired(t => t.SubQuestionnaireQuestionOverwrite)
                .WithMany(t => t.SQQOPossibleAnswers)
                .HasForeignKey(d => d.SubQuestionnaireQuestionOverwriteId);

        }
    }
}
