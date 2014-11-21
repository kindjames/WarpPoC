using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorHistoryMap : EntityTypeConfiguration<AssessorHistory>
    {
        public AssessorHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorHistoryId);

            // Properties
            this.Property(t => t.AssessorHistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AssessorHistory");
            this.Property(t => t.AssessorHistoryId).HasColumnName("AssessorHistoryID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.AssessorStatusId).HasColumnName("AssessorStatusID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.AssessorStatusChangeReasonId).HasColumnName("AssessorStatusChangeReasonID");
            this.Property(t => t.AssessorLevelId).HasColumnName("AssessorLevelID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.AssessorLevel)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorLevelId);
            this.HasRequired(t => t.AssessorStatu)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorStatusId);
            this.HasRequired(t => t.AssessorStatusChangeReason)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorStatusChangeReasonId);

        }
    }
}
