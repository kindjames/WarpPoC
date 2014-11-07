using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class NoteCalendarMap : EntityTypeConfiguration<NoteCalendar>
    {
        public NoteCalendarMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteCalendarID);

            // Properties
            this.Property(t => t.NoteCalendarID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NoteCalendar");
            this.Property(t => t.NoteCalendarID).HasColumnName("NoteCalendarID");
            this.Property(t => t.NoteID).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Note)
                .WithMany(t => t.NoteCalendars)
                .HasForeignKey(d => d.NoteID);

        }
    }
}
