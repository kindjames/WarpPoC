using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubQuestionnaireQuestionOverwriteMap : EntityTypeConfiguration<SubQuestionnaireQuestionOverwrite>
    {
        public SubQuestionnaireQuestionOverwriteMap()
        {
            // Primary Key
            HasKey(t => t.SubQuestionnaireQuestionOverwriteId);

            // Properties
            Property(t => t.SubQuestionnaireQuestionOverwriteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Hint)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("SubQuestionnaireQuestionOverwrite");
            Property(t => t.SubQuestionnaireQuestionOverwriteId).HasColumnName("SubQuestionnaireQuestionOverwriteID");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            Property(t => t.QuestionOverwriteId).HasColumnName("QuestionOverwriteID");
            Property(t => t.Dynamic).HasColumnName("Dynamic");
            Property(t => t.QuestionSectionId).HasColumnName("QuestionSectionID");
            Property(t => t.SectionNumber).HasColumnName("SectionNumber");
            Property(t => t.QuestionNumber).HasColumnName("QuestionNumber");
            Property(t => t.ManagementCategoryId).HasColumnName("ManagementCategoryID");
            Property(t => t.BenchmarkId).HasColumnName("BenchmarkID");
            Property(t => t.QuestionDepartmentId).HasColumnName("QuestionDepartmentID");
            Property(t => t.MaxScore).HasColumnName("MaxScore");
            Property(t => t.MinAnswer).HasColumnName("MinAnswer");
            Property(t => t.MaxAnswer).HasColumnName("MaxAnswer");
            Property(t => t.Hint).HasColumnName("Hint");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Benchmark)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.BenchmarkId);
            HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.ManagementCategoryId);
            HasRequired(t => t.QuestionDepartment)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionDepartmentId);
            HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionnaireQuestionId);
            HasRequired(t => t.QuestionOverwrite)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionOverwriteId);
            HasRequired(t => t.QuestionSection)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionSectionId);
            HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
