using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class FurtherNoteMap : EntityTypeConfiguration<FurtherNote>
    {
        public FurtherNoteMap()
        {
            // Primary Key
            HasKey(t => t.FurthernoteId);

            // Properties
            Property(t => t.FurthernoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Note1)
                .IsRequired()
                .HasMaxLength(300);

            Property(t => t.Note2)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.Note3)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.Note4)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("FurtherNote");
            Property(t => t.FurthernoteId).HasColumnName("FurthernoteID");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.Note1).HasColumnName("Note1");
            Property(t => t.Note2).HasColumnName("Note2");
            Property(t => t.Note3).HasColumnName("Note3");
            Property(t => t.Note4).HasColumnName("Note4");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Note)
                .WithMany(t => t.FurtherNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
