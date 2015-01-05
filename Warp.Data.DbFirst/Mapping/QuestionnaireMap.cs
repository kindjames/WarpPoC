using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionnaireMap : EntityTypeConfiguration<Questionnaire>
    {
        public QuestionnaireMap()
        {
            // Primary Key
            HasKey(t => t.QuestionnaireId);

            // Properties
            Property(t => t.QuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Questionnaire");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.QuestionnaireStatusId).HasColumnName("QuestionnaireStatusID");
            Property(t => t.QuestionnaireTypeId).HasColumnName("QuestionnaireTypeID");
            Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.QuestionnaireStatus)
                .WithMany(t => t.Questionnaires)
                .HasForeignKey(d => d.QuestionnaireStatusId);
            HasRequired(t => t.VisitType)
                .WithMany(t => t.Questionnaires)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
