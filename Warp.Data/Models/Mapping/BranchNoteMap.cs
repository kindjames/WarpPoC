using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchNoteMap : EntityTypeConfiguration<BranchNote>
    {
        public BranchNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchNoteID);

            // Properties
            this.Property(t => t.BranchNoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BranchNote");
            this.Property(t => t.BranchNoteID).HasColumnName("BranchNoteID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.NoteID).HasColumnName("NoteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.BranchNotes)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.Note)
                .WithMany(t => t.BranchNotes)
                .HasForeignKey(d => d.NoteID);

        }
    }
}
