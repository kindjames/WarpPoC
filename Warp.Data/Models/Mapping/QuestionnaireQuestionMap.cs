using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionnaireQuestionMap : EntityTypeConfiguration<QuestionnaireQuestion>
    {
        public QuestionnaireQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireQuestionID);

            // Properties
            this.Property(t => t.QuestionnaireQuestionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QuestionOverwriteText)
                .HasMaxLength(2000);

            this.Property(t => t.QuestionOverwriteHint)
                .HasMaxLength(500);

            this.Property(t => t.Hint)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("QuestionnaireQuestion");
            this.Property(t => t.QuestionnaireQuestionID).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.QuestionSectionID).HasColumnName("QuestionSectionID");
            this.Property(t => t.SectionNumber).HasColumnName("SectionNumber");
            this.Property(t => t.QuestionID).HasColumnName("QuestionID");
            this.Property(t => t.QuestionOverwriteText).HasColumnName("QuestionOverwriteText");
            this.Property(t => t.QuestionOverwriteHint).HasColumnName("QuestionOverwriteHint");
            this.Property(t => t.QuestionNumber).HasColumnName("QuestionNumber");
            this.Property(t => t.ManagementCategoryID).HasColumnName("ManagementCategoryID");
            this.Property(t => t.BenchmarkID).HasColumnName("BenchmarkID");
            this.Property(t => t.QuestionDepartmentID).HasColumnName("QuestionDepartmentID");
            this.Property(t => t.MaxScore).HasColumnName("MaxScore");
            this.Property(t => t.MinAnswer).HasColumnName("MinAnswer");
            this.Property(t => t.MaxAnswer).HasColumnName("MaxAnswer");
            this.Property(t => t.Dynamic).HasColumnName("Dynamic");
            this.Property(t => t.Hint).HasColumnName("Hint");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateActive).HasColumnName("DateActive");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");

            // Relationships
            this.HasRequired(t => t.Benchmark)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.BenchmarkID);
            this.HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.ManagementCategoryID);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionID);
            this.HasRequired(t => t.QuestionDepartment)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionDepartmentID);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasRequired(t => t.QuestionSection)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionSectionID);

        }
    }
}
