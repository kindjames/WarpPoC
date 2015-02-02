using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CCTFurtherNoteMap : EntityTypeConfiguration<CCTFurtherNote>
    {
        public CCTFurtherNoteMap()
        {
            // Primary Key
            HasKey(t => t.CCTFurtherNotesId);

            // Properties
            Property(t => t.CCTFurtherNotesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Note1)
                .IsRequired()
                .HasMaxLength(300);

            Property(t => t.Note2)
                .HasMaxLength(500);

            Property(t => t.Note3)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("CCTFurtherNotes");
            Property(t => t.CCTFurtherNotesId).HasColumnName("CCTFurtherNotesID");
            Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            Property(t => t.Note1).HasColumnName("Note1");
            Property(t => t.Note2).HasColumnName("Note2");
            Property(t => t.Note3).HasColumnName("Note3");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.CCTFurtherNotes)
                .HasForeignKey(d => d.ClientContactTrackingId);

        }
    }
}
