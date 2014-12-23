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
            HasKey(t => t.ClientNoteId);

            // Properties
            Property(t => t.ClientNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ClientNote");
            Property(t => t.ClientNoteId).HasColumnName("ClientNoteID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientNotes)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Note)
                .WithMany(t => t.ClientNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
