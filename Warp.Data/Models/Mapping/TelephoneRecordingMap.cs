using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TelephoneRecordingMap : EntityTypeConfiguration<TelephoneRecording>
    {
        public TelephoneRecordingMap()
        {
            // Primary Key
            this.HasKey(t => t.TelephoneRecordingID);

            // Properties
            this.Property(t => t.TelephoneRecordingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FilePath)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TelephoneRecording");
            this.Property(t => t.TelephoneRecordingID).HasColumnName("TelephoneRecordingID");
            this.Property(t => t.AssessmentID).HasColumnName("AssessmentID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.FilePath).HasColumnName("FilePath");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");

            // Relationships
            this.HasRequired(t => t.Assessment)
                .WithMany(t => t.TelephoneRecordings)
                .HasForeignKey(d => d.AssessmentID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.TelephoneRecordings)
                .HasForeignKey(d => d.AssessorID);

        }
    }
}
