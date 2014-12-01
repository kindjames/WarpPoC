using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandNoteMap : EntityTypeConfiguration<BrandNote>
    {
        public BrandNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandNoteId);

            // Properties
            this.Property(t => t.BrandNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BrandNote");
            this.Property(t => t.BrandNoteId).HasColumnName("BrandNoteID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandNotes)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.BrandNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
