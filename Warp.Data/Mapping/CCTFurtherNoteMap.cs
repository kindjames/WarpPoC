using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CCTFurtherNoteMap : EntityTypeConfiguration<CCTFurtherNote>
    {
        public CCTFurtherNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.CCTFurtherNotesId);

            // Properties
            this.Property(t => t.CCTFurtherNotesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Note1)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.Note2)
                .HasMaxLength(500);

            this.Property(t => t.Note3)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CCTFurtherNotes");
            this.Property(t => t.CCTFurtherNotesId).HasColumnName("CCTFurtherNotesID");
            this.Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            this.Property(t => t.Note1).HasColumnName("Note1");
            this.Property(t => t.Note2).HasColumnName("Note2");
            this.Property(t => t.Note3).HasColumnName("Note3");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.CCTFurtherNotes)
                .HasForeignKey(d => d.ClientContactTrackingId);

        }
    }
}
