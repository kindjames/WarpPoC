using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitNoteMap : EntityTypeConfiguration<VisitNote>
    {
        public VisitNoteMap()
        {
            // Primary Key
            HasKey(t => t.VisitNoteId);

            // Properties
            Property(t => t.VisitNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitNote");
            Property(t => t.VisitNoteId).HasColumnName("VisitNoteID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Note)
                .WithMany(t => t.VisitNotes)
                .HasForeignKey(d => d.NoteId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitNotes)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
