using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientNoteMap : EntityTypeConfiguration<ClientNote>
    {
        public ClientNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientNoteId);

            // Properties
            this.Property(t => t.ClientNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientNote");
            this.Property(t => t.ClientNoteId).HasColumnName("ClientNoteID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientNotes)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.ClientNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
