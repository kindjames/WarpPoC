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
            HasKey(t => t.NoteId);

            // Properties
            Property(t => t.NoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Note1)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.DeactivateReason)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Note");
            Property(t => t.NoteId).HasColumnName("NoteID");
            Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.NoteTypeId).HasColumnName("NoteTypeID");
            Property(t => t.Note1).HasColumnName("Note");
            Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            Property(t => t.DeactivateReason).HasColumnName("DeactivateReason");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.NoteType)
                .WithMany(t => t.Notes)
                .HasForeignKey(d => d.NoteTypeId);

        }
    }
}
