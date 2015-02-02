using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchQuestionnaireMap : EntityTypeConfiguration<BranchQuestionnaire>
    {
        public BranchQuestionnaireMap()
        {
            // Primary Key
            HasKey(t => t.BranchQuestionnaireId);

            // Properties
            Property(t => t.BranchQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BranchQuestionnaire");
            Property(t => t.BranchQuestionnaireId).HasColumnName("BranchQuestionnaireID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
