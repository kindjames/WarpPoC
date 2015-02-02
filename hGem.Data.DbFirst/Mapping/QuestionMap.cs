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
            HasKey(t => t.QuestionId);

            // Properties
            Property(t => t.QuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(2000);

            Property(t => t.DefaultHint)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Question");
            Property(t => t.QuestionId).HasColumnName("QuestionID");
            Property(t => t.Text).HasColumnName("Text");
            Property(t => t.QuestionTypeId).HasColumnName("QuestionTypeID");
            Property(t => t.DefaultQuestionSectionId).HasColumnName("DefaultQuestionSectionID");
            Property(t => t.DefaultManagementCategoryId).HasColumnName("DefaultManagementCategoryID");
            Property(t => t.DefaultBenchmarkId).HasColumnName("DefaultBenchmarkID");
            Property(t => t.DefaultQuestionDepartmentId).HasColumnName("DefaultQuestionDepartmentID");
            Property(t => t.DefaultHint).HasColumnName("DefaultHint");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.TrackingQuestionId).HasColumnName("TrackingQuestionID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Client)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Benchmark)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultBenchmarkId);
            HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultManagementCategoryId);
            HasOptional(t => t.QuestionSection)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultQuestionSectionId);
            HasRequired(t => t.QuestionType)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.QuestionTypeId);

        }
    }
}
