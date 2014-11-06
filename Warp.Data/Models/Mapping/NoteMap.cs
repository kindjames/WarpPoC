using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class NoteMap : EntityTypeConfiguration<Note>
    {
        public NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteID);

            // Properties
            this.Property(t => t.NoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note1)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.DeactivateReason)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Note");
            this.Property(t => t.NoteID).HasColumnName("NoteID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.NoteTypeID).HasColumnName("NoteTypeID");
            this.Property(t => t.Note1).HasColumnName("Note");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DeactivatedByAdminID).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.DeactivatedTimeStamp).HasColumnName("DeactivatedTimeStamp");
            this.Property(t => t.DeactivateReason).HasColumnName("DeactivateReason");

            // Relationships
            this.HasRequired(t => t.NoteType)
                .WithMany(t => t.Notes)
                .HasForeignKey(d => d.NoteTypeID);

        }
    }
}
