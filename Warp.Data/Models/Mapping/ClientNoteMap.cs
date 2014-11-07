using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientNoteMap : EntityTypeConfiguration<ClientNote>
    {
        public ClientNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientNoteID);

            // Properties
            this.Property(t => t.ClientNoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientNote");
            this.Property(t => t.ClientNoteID).HasColumnName("ClientNoteID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.NoteID).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientNotes)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.ClientNotes)
                .HasForeignKey(d => d.NoteID);

        }
    }
}
