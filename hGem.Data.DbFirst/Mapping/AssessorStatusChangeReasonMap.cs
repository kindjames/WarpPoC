using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorStatusChangeReasonMap : EntityTypeConfiguration<AssessorStatusChangeReason>
    {
        public AssessorStatusChangeReasonMap()
        {
            // Primary Key
            HasKey(t => t.AssessorStatusChangeReasonId);

            // Properties
            Property(t => t.AssessorStatusChangeReasonId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("AssessorStatusChangeReason");
            Property(t => t.AssessorStatusChangeReasonId).HasColumnName("AssessorStatusChangeReasonID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
