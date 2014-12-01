using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionId);

            // Properties
            this.Property(t => t.QuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.DefaultHint)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Question");
            this.Property(t => t.QuestionId).HasColumnName("QuestionID");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.QuestionTypeId).HasColumnName("QuestionTypeID");
            this.Property(t => t.DefaultQuestionSectionId).HasColumnName("DefaultQuestionSectionID");
            this.Property(t => t.DefaultManagementCategoryId).HasColumnName("DefaultManagementCategoryID");
            this.Property(t => t.DefaultBenchmarkId).HasColumnName("DefaultBenchmarkID");
            this.Property(t => t.DefaultQuestionDepartmentId).HasColumnName("DefaultQuestionDepartmentID");
            this.Property(t => t.DefaultHint).HasColumnName("DefaultHint");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.TrackingQuestionId).HasColumnName("TrackingQuestionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Client)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Benchmark)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultBenchmarkId);
            this.HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultManagementCategoryId);
            this.HasOptional(t => t.QuestionSection)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultQuestionSectionId);
            this.HasRequired(t => t.QuestionType)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.QuestionTypeId);

        }
    }
}
