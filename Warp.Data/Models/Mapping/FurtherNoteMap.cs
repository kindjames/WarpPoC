using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class FurtherNoteMap : EntityTypeConfiguration<FurtherNote>
    {
        public FurtherNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.FurthernoteID);

            // Properties
            this.Property(t => t.FurthernoteID)
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
            this.Property(t => t.FurthernoteID).HasColumnName("FurthernoteID");
            this.Property(t => t.NoteID).HasColumnName("NoteID");
            this.Property(t => t.Note1).HasColumnName("Note1");
            this.Property(t => t.Note2).HasColumnName("Note2");
            this.Property(t => t.Note3).HasColumnName("Note3");
            this.Property(t => t.Note4).HasColumnName("Note4");

            // Relationships
            this.HasRequired(t => t.Note)
                .WithMany(t => t.FurtherNotes)
                .HasForeignKey(d => d.NoteID);

        }
    }
}
