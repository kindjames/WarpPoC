using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionnaireQuestionMap : EntityTypeConfiguration<QuestionnaireQuestion>
    {
        public QuestionnaireQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireQuestionId);

            // Properties
            this.Property(t => t.QuestionnaireQuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QuestionOverwriteText)
                .HasMaxLength(2000);

            this.Property(t => t.QuestionOverwriteHint)
                .HasMaxLength(500);

            this.Property(t => t.Hint)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("QuestionnaireQuestion");
            this.Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.QuestionSectionId).HasColumnName("QuestionSectionID");
            this.Property(t => t.SectionNumber).HasColumnName("SectionNumber");
            this.Property(t => t.QuestionId).HasColumnName("QuestionID");
            this.Property(t => t.QuestionOverwriteText).HasColumnName("QuestionOverwriteText");
            this.Property(t => t.QuestionOverwriteHint).HasColumnName("QuestionOverwriteHint");
            this.Property(t => t.QuestionNumber).HasColumnName("QuestionNumber");
            this.Property(t => t.ManagementCategoryId).HasColumnName("ManagementCategoryID");
            this.Property(t => t.BenchmarkId).HasColumnName("BenchmarkID");
            this.Property(t => t.QuestionDepartmentId).HasColumnName("QuestionDepartmentID");
            this.Property(t => t.MaxScore).HasColumnName("MaxScore");
            this.Property(t => t.MinAnswer).HasColumnName("MinAnswer");
            this.Property(t => t.MaxAnswer).HasColumnName("MaxAnswer");
            this.Property(t => t.Dynamic).HasColumnName("Dynamic");
            this.Property(t => t.Hint).HasColumnName("Hint");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Benchmark)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.BenchmarkId);
            this.HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.ManagementCategoryId);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionId);
            this.HasRequired(t => t.QuestionDepartment)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionDepartmentId);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasRequired(t => t.QuestionSection)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionSectionId);

        }
    }
}
