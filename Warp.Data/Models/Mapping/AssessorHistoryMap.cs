using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorHistoryMap : EntityTypeConfiguration<AssessorHistory>
    {
        public AssessorHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorHistoryID);

            // Properties
            this.Property(t => t.AssessorHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AssessorHistory");
            this.Property(t => t.AssessorHistoryID).HasColumnName("AssessorHistoryID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.AssessorStatusID).HasColumnName("AssessorStatusID");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.AssessorStatusChangeReasonID).HasColumnName("AssessorStatusChangeReasonID");
            this.Property(t => t.AssessorLevelID).HasColumnName("AssessorLevelID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.AssessorLevel)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorLevelID);
            this.HasRequired(t => t.AssessorStatu)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorStatusID);
            this.HasRequired(t => t.AssessorStatusChangeReason)
                .WithMany(t => t.AssessorHistories)
                .HasForeignKey(d => d.AssessorStatusChangeReasonID);

        }
    }
}
