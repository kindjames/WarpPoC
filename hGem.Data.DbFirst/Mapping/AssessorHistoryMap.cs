using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorHistoryMap : EntityTypeConfiguration<AssessorHistory>
    {
        public AssessorHistoryMap()
        {
            // Primary Key
            HasKey(t => t.AssessorHistoryId);

            // Properties
            Property(t => t.AssessorHistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Comment)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("AssessorHistory");
            Property(t => t.AssessorHistoryId).HasColumnName("AssessorHistoryID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.AssessorStatusId).HasColumnName("AssessorStatusID");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.AssessorStatusChangeReasonId).HasColumnName("AssessorStatusChangeReasonID");
            Property(t => t.AssessorLevelId).HasColumnName("AssessorLevelID");
            Property(t => t.Comment).HasColumnName("Comment");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.AssessorLevel)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorLevelId);
            HasRequired(t => t.AssessorStatus)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorStatusId);
            HasRequired(t => t.AssessorStatusChangeReason)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorStatusChangeReasonId);

        }
    }
}
