using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorStatusMap : EntityTypeConfiguration<AssessorStatus>
    {
        public AssessorStatusMap()
        {
            // Primary Key
            HasKey(t => t.AssessorStatusId);

            // Properties
            Property(t => t.AssessorStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.InternalName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.ExternalName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("AssessorStatus");
            Property(t => t.AssessorStatusId).HasColumnName("AssessorStatusID");
            Property(t => t.InternalName).HasColumnName("InternalName");
            Property(t => t.ExternalName).HasColumnName("ExternalName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
