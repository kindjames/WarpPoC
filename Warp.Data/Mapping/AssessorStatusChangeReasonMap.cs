using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorStatusChangeReasonMap : EntityTypeConfiguration<AssessorStatusChangeReason>
    {
        public AssessorStatusChangeReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorStatusChangeReasonId);

            // Properties
            this.Property(t => t.AssessorStatusChangeReasonId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AssessorStatusChangeReason");
            this.Property(t => t.AssessorStatusChangeReasonId).HasColumnName("AssessorStatusChangeReasonID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
