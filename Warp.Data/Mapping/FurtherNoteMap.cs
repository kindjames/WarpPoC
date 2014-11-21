using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class FurtherNoteMap : EntityTypeConfiguration<FurtherNote>
    {
        public FurtherNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.FurthernoteId);

            // Properties
            this.Property(t => t.FurthernoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note1)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.Note2)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Note3)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Note4)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("FurtherNote");
            this.Property(t => t.FurthernoteId).HasColumnName("FurthernoteID");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.Note1).HasColumnName("Note1");
            this.Property(t => t.Note2).HasColumnName("Note2");
            this.Property(t => t.Note3).HasColumnName("Note3");
            this.Property(t => t.Note4).HasColumnName("Note4");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Note)
                .WithMany(t => t.FurtherNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
