using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TelephoneRecordingMap : EntityTypeConfiguration<TelephoneRecording>
    {
        public TelephoneRecordingMap()
        {
            // Primary Key
            this.HasKey(t => t.TelephoneRecordingId);

            // Properties
            this.Property(t => t.TelephoneRecordingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FilePath)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TelephoneRecording");
            this.Property(t => t.TelephoneRecordingId).HasColumnName("TelephoneRecordingID");
            this.Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.FilePath).HasColumnName("FilePath");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessment)
                .WithMany(t => t.TelephoneRecordings)
                .HasForeignKey(d => d.AssessmentId);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.TelephoneRecordings)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
