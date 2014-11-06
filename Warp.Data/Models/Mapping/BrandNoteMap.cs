using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BrandNoteMap : EntityTypeConfiguration<BrandNote>
    {
        public BrandNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandNoteID);

            // Properties
            this.Property(t => t.BrandNoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BrandNote");
            this.Property(t => t.BrandNoteID).HasColumnName("BrandNoteID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.NoteID).HasColumnName("NoteID");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandNotes)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.BrandNotes)
                .HasForeignKey(d => d.NoteID);

        }
    }
}
