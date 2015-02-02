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
            HasKey(t => t.TelephoneRecordingId);

            // Properties
            Property(t => t.TelephoneRecordingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.FilePath)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("TelephoneRecording");
            Property(t => t.TelephoneRecordingId).HasColumnName("TelephoneRecordingID");
            Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.FilePath).HasColumnName("FilePath");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessment)
                .WithMany(t => t.TelephoneRecordings)
                .HasForeignKey(d => d.AssessmentId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.TelephoneRecordings)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
