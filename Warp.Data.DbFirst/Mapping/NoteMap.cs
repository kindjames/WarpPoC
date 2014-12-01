using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class NoteMap : EntityTypeConfiguration<Note>
    {
        public NoteMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteId);

            // Properties
            this.Property(t => t.NoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note1)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.DeactivateReason)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Note");
            this.Property(t => t.NoteId).HasColumnName("NoteID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.NoteTypeId).HasColumnName("NoteTypeID");
            this.Property(t => t.Note1).HasColumnName("Note");
            this.Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            this.Property(t => t.DeactivateReason).HasColumnName("DeactivateReason");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.NoteType)
                .WithMany(t => t.Notes)
                .HasForeignKey(d => d.NoteTypeId);

        }
    }
}
