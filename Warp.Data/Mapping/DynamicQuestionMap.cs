using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class DynamicQuestionMap : EntityTypeConfiguration<DynamicQuestion>
    {
        public DynamicQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.DynamicQuestionId);

            // Properties
            this.Property(t => t.DynamicQuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DynamicQuestion");
            this.Property(t => t.DynamicQuestionId).HasColumnName("DynamicQuestionID");
            this.Property(t => t.MasterQuestionnaireQuestionId).HasColumnName("MasterQuestionnaireQuestionID");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.ChildQuestionnaireQuestionId).HasColumnName("ChildQuestionnaireQuestionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.DynamicQuestions)
                .HasForeignKey(d => d.PossibleAnswerId);
            this.HasOptional(t => t.QuestionnaireQuestion)
                .WithMany(t => t.DynamicQuestions)
                .HasForeignKey(d => d.ChildQuestionnaireQuestionId);
            this.HasRequired(t => t.QuestionnaireQuestion1)
                .WithMany(t => t.DynamicQuestions1)
                .HasForeignKey(d => d.MasterQuestionnaireQuestionId);

        }
    }
}
