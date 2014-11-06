using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorStatusChangeReasonMap : EntityTypeConfiguration<AssessorStatusChangeReason>
    {
        public AssessorStatusChangeReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorStatusChangeReasonID);

            // Properties
            this.Property(t => t.AssessorStatusChangeReasonID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AssessorStatusChangeReason");
            this.Property(t => t.AssessorStatusChangeReasonID).HasColumnName("AssessorStatusChangeReasonID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
