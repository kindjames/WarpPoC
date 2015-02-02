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
            HasKey(t => t.NoteCalendarId);

            // Properties
            Property(t => t.NoteCalendarId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("NoteCalendar");
            Property(t => t.NoteCalendarId).HasColumnName("NoteCalendarID");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Note)
                .WithMany(t => t.NoteCalendars)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
