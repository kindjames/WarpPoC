using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DynamicQuestionMap : EntityTypeConfiguration<DynamicQuestion>
    {
        public DynamicQuestionMap()
        {
            // Primary Key
            HasKey(t => t.DynamicQuestionId);

            // Properties
            Property(t => t.DynamicQuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("DynamicQuestion");
            Property(t => t.DynamicQuestionId).HasColumnName("DynamicQuestionID");
            Property(t => t.MasterQuestionnaireQuestionId).HasColumnName("MasterQuestionnaireQuestionID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.ChildQuestionnaireQuestionId).HasColumnName("ChildQuestionnaireQuestionID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.DynamicQuestions)
                .HasForeignKey(d => d.PossibleAnswerId);
            HasOptional(t => t.QuestionnaireQuestion)
                .WithMany(t => t.DynamicQuestions)
                .HasForeignKey(d => d.ChildQuestionnaireQuestionId);
            HasRequired(t => t.QuestionnaireQuestion1)
                .WithMany(t => t.DynamicQuestions1)
                .HasForeignKey(d => d.MasterQuestionnaireQuestionId);

        }
    }
}
