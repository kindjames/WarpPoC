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
            HasKey(t => t.BrandNoteId);

            // Properties
            Property(t => t.BrandNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BrandNote");
            Property(t => t.BrandNoteId).HasColumnName("BrandNoteID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BrandNotes)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.Note)
                .WithMany(t => t.BrandNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
