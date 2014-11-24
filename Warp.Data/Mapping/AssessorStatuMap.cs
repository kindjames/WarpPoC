using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorStatusMap : EntityTypeConfiguration<AssessorStatus>
    {
        public AssessorStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorStatusId);

            // Properties
            this.Property(t => t.AssessorStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InternalName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ExternalName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AssessorStatus");
            this.Property(t => t.AssessorStatusId).HasColumnName("AssessorStatusID");
            this.Property(t => t.InternalName).HasColumnName("InternalName");
            this.Property(t => t.ExternalName).HasColumnName("ExternalName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
