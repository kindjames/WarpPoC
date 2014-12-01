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
            this.HasKey(t => t.SubQuestionnaireQuestionOverwriteId);

            // Properties
            this.Property(t => t.SubQuestionnaireQuestionOverwriteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hint)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("SubQuestionnaireQuestionOverwrite");
            this.Property(t => t.SubQuestionnaireQuestionOverwriteId).HasColumnName("SubQuestionnaireQuestionOverwriteID");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.QuestionOverwriteId).HasColumnName("QuestionOverwriteID");
            this.Property(t => t.Dynamic).HasColumnName("Dynamic");
            this.Property(t => t.QuestionSectionId).HasColumnName("QuestionSectionID");
            this.Property(t => t.SectionNumber).HasColumnName("SectionNumber");
            this.Property(t => t.QuestionNumber).HasColumnName("QuestionNumber");
            this.Property(t => t.ManagementCategoryId).HasColumnName("ManagementCategoryID");
            this.Property(t => t.BenchmarkId).HasColumnName("BenchmarkID");
            this.Property(t => t.QuestionDepartmentId).HasColumnName("QuestionDepartmentID");
            this.Property(t => t.MaxScore).HasColumnName("MaxScore");
            this.Property(t => t.MinAnswer).HasColumnName("MinAnswer");
            this.Property(t => t.MaxAnswer).HasColumnName("MaxAnswer");
            this.Property(t => t.Hint).HasColumnName("Hint");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Benchmark)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.BenchmarkId);
            this.HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.ManagementCategoryId);
            this.HasRequired(t => t.QuestionDepartment)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionDepartmentId);
            this.HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionnaireQuestionId);
            this.HasRequired(t => t.QuestionOverwrite)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionOverwriteId);
            this.HasRequired(t => t.QuestionSection)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionSectionId);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
