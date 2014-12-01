using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorNoteMap : EntityTypeConfiguration<AssessorNote>
    {
        public AssessorNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorNoteId);

            // Properties
            this.Property(t => t.AssessorNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorNote");
            this.Property(t => t.AssessorNoteId).HasColumnName("AssessorNoteID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorNotes)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.AssessorNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
