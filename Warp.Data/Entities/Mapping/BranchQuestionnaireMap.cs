using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BranchQuestionnaireMap : EntityTypeConfiguration<BranchQuestionnaire>
    {
        public BranchQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchQuestionnaireID);

            // Properties
            this.Property(t => t.BranchQuestionnaireID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BranchQuestionnaire");
            this.Property(t => t.BranchQuestionnaireID).HasColumnName("BranchQuestionnaireID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.BranchQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireID);

        }
    }
}
