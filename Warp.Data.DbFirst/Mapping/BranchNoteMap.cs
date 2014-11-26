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
            this.HasKey(t => t.BranchNoteId);

            // Properties
            this.Property(t => t.BranchNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BranchNote");
            this.Property(t => t.BranchNoteId).HasColumnName("BranchNoteID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchNotes)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.BranchNotes)
                .HasForeignKey(d => d.NoteId);

        }
    }
}
