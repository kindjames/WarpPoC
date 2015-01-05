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
            HasKey(t => t.AssessorNoteId);

            // Properties
            Property(t => t.AssessorNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorNote");
            Property(t => t.AssessorNoteId).HasColumnName("AssessorNoteID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorNotes)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.Note)
                .WithMany(t => t.AssessorNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
