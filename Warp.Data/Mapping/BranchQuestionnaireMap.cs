using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BranchQuestionnaireMap : EntityTypeConfiguration<BranchQuestionnaire>
    {
        public BranchQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchQuestionnaireId);

            // Properties
            this.Property(t => t.BranchQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BranchQuestionnaire");
            this.Property(t => t.BranchQuestionnaireId).HasColumnName("BranchQuestionnaireID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
