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
            this.HasKey(t => t.VisitNoteId);

            // Properties
            this.Property(t => t.VisitNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitNote");
            this.Property(t => t.VisitNoteId).HasColumnName("VisitNoteID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Note)
                .WithMany(t => t.VisitNotes)
                .HasForeignKey(d => d.NoteId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitNotes)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
