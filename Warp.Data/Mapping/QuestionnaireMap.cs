using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionnaireMap : EntityTypeConfiguration<Questionnaire>
    {
        public QuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireId);

            // Properties
            this.Property(t => t.QuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Questionnaire");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.QuestionnaireStatusId).HasColumnName("QuestionnaireStatusID");
            this.Property(t => t.QuestionnaireTypeId).HasColumnName("QuestionnaireTypeID");
            this.Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.QuestionnaireStatu)
                .WithMany(t => t.Questionnaires)
                .HasForeignKey(d => d.QuestionnaireStatusId);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.Questionnaires)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
