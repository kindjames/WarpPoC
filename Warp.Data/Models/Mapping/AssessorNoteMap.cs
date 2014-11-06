using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorNoteMap : EntityTypeConfiguration<AssessorNote>
    {
        public AssessorNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorNoteID);

            // Properties
            this.Property(t => t.AssessorNoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorNote");
            this.Property(t => t.AssessorNoteID).HasColumnName("AssessorNoteID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.NoteID).HasColumnName("NoteID");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorNotes)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.AssessorNotes)
                .HasForeignKey(d => d.NoteID);

        }
    }
}
