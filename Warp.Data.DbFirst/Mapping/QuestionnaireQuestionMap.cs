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
            HasKey(t => t.QuestionnaireQuestionId);

            // Properties
            Property(t => t.QuestionnaireQuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.QuestionOverwriteText)
                .HasMaxLength(2000);

            Property(t => t.QuestionOverwriteHint)
                .HasMaxLength(500);

            Property(t => t.Hint)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("QuestionnaireQuestion");
            Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.QuestionSectionId).HasColumnName("QuestionSectionID");
            Property(t => t.SectionNumber).HasColumnName("SectionNumber");
            Property(t => t.QuestionId).HasColumnName("QuestionID");
            Property(t => t.QuestionOverwriteText).HasColumnName("QuestionOverwriteText");
            Property(t => t.QuestionOverwriteHint).HasColumnName("QuestionOverwriteHint");
            Property(t => t.QuestionNumber).HasColumnName("QuestionNumber");
            Property(t => t.ManagementCategoryId).HasColumnName("ManagementCategoryID");
            Property(t => t.BenchmarkId).HasColumnName("BenchmarkID");
            Property(t => t.QuestionDepartmentId).HasColumnName("QuestionDepartmentID");
            Property(t => t.MaxScore).HasColumnName("MaxScore");
            Property(t => t.MinAnswer).HasColumnName("MinAnswer");
            Property(t => t.MaxAnswer).HasColumnName("MaxAnswer");
            Property(t => t.Dynamic).HasColumnName("Dynamic");
            Property(t => t.Hint).HasColumnName("Hint");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Benchmark)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.BenchmarkId);
            HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.ManagementCategoryId);
            HasRequired(t => t.Question)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionId);
            HasRequired(t => t.QuestionDepartment)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionDepartmentId);
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionnaireId);
            HasRequired(t => t.QuestionSection)
                .WithMany(t => t.QuestionnaireQuestions)
                .HasForeignKey(d => d.QuestionSectionId);

        }
    }
}
