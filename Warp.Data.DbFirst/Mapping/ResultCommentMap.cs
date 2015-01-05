using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ResultCommentMap : EntityTypeConfiguration<ResultComment>
    {
        public ResultCommentMap()
        {
            // Primary Key
            HasKey(t => t.ResultCommentId);

            // Properties
            Property(t => t.ResultCommentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.AssessorComments)
                .IsRequired()
                .HasMaxLength(1000);

            Property(t => t.AdminComments)
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("ResultComment");
            Property(t => t.ResultCommentId).HasColumnName("ResultCommentID");
            Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.AssessorComments).HasColumnName("AssessorComments");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.AdminComments).HasColumnName("AdminComments");
            Property(t => t.DateCompleted).HasColumnName("DateCompleted");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessment)
                .WithMany(t => t.ResultComments)
                .HasForeignKey(d => d.AssessmentId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.ResultComments)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
