using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchNoteMap : EntityTypeConfiguration<BranchNote>
    {
        public BranchNoteMap()
        {
            // Primary Key
            HasKey(t => t.BranchNoteId);

            // Properties
            Property(t => t.BranchNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BranchNote");
            Property(t => t.BranchNoteId).HasColumnName("BranchNoteID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.BranchNotes)
                .HasForeignKey(d => d.BranchId);
            HasRequired(t => t.Note)
                .WithMany(t => t.BranchNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
