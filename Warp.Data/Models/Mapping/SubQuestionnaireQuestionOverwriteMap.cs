using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SubQuestionnaireQuestionOverwriteMap : EntityTypeConfiguration<SubQuestionnaireQuestionOverwrite>
    {
        public SubQuestionnaireQuestionOverwriteMap()
        {
            // Primary Key
            this.HasKey(t => t.SubQuestionnaireQuestionOverwriteID);

            // Properties
            this.Property(t => t.SubQuestionnaireQuestionOverwriteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Hint)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("SubQuestionnaireQuestionOverwrite");
            this.Property(t => t.SubQuestionnaireQuestionOverwriteID).HasColumnName("SubQuestionnaireQuestionOverwriteID");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.QuestionnaireQuestionID).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.QuestionOverwriteID).HasColumnName("QuestionOverwriteID");
            this.Property(t => t.Dynamic).HasColumnName("Dynamic");
            this.Property(t => t.QuestionSectionID).HasColumnName("QuestionSectionID");
            this.Property(t => t.SectionNumber).HasColumnName("SectionNumber");
            this.Property(t => t.QuestionNumber).HasColumnName("QuestionNumber");
            this.Property(t => t.ManagementCategoryID).HasColumnName("ManagementCategoryID");
            this.Property(t => t.BenchmarkID).HasColumnName("BenchmarkID");
            this.Property(t => t.QuestionDepartmentID).HasColumnName("QuestionDepartmentID");
            this.Property(t => t.MaxScore).HasColumnName("MaxScore");
            this.Property(t => t.MinAnswer).HasColumnName("MinAnswer");
            this.Property(t => t.MaxAnswer).HasColumnName("MaxAnswer");
            this.Property(t => t.Hint).HasColumnName("Hint");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");

            // Relationships
            this.HasRequired(t => t.Benchmark)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.BenchmarkID);
            this.HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.ManagementCategoryID);
            this.HasRequired(t => t.QuestionDepartment)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionDepartmentID);
            this.HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionnaireQuestionID);
            this.HasRequired(t => t.QuestionOverwrite)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionOverwriteID);
            this.HasRequired(t => t.QuestionSection)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.QuestionSectionID);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.SubQuestionnaireQuestionOverwrites)
                .HasForeignKey(d => d.SubQuestionnaireID);

        }
    }
}
