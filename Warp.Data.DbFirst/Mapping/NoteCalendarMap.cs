using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class NoteCalendarMap : EntityTypeConfiguration<NoteCalendar>
    {
        public NoteCalendarMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteCalendarId);

            // Properties
            this.Property(t => t.NoteCalendarId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NoteCalendar");
            this.Property(t => t.NoteCalendarId).HasColumnName("NoteCalendarID");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Note)
                .WithMany(t => t.NoteCalendars)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
