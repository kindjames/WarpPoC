using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionID);

            // Properties
            this.Property(t => t.QuestionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.DefaultHint)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Question");
            this.Property(t => t.QuestionID).HasColumnName("QuestionID");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.QuestionTypeID).HasColumnName("QuestionTypeID");
            this.Property(t => t.DefaultQuestionSectionID).HasColumnName("DefaultQuestionSectionID");
            this.Property(t => t.DefaultManagementCategoryID).HasColumnName("DefaultManagementCategoryID");
            this.Property(t => t.DefaultBenchmarkID).HasColumnName("DefaultBenchmarkID");
            this.Property(t => t.DefaultQuestionDepartmentID).HasColumnName("DefaultQuestionDepartmentID");
            this.Property(t => t.DefaultHint).HasColumnName("DefaultHint");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.TrackingQuestionID).HasColumnName("TrackingQuestionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Client)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Benchmark)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultBenchmarkID);
            this.HasRequired(t => t.ManagementCategory)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultManagementCategoryID);
            this.HasOptional(t => t.QuestionSection)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.DefaultQuestionSectionID);
            this.HasRequired(t => t.QuestionType)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.QuestionTypeID);

        }
    }
}
