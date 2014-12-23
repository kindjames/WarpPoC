using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitStatusMap : EntityTypeConfiguration<VisitStatus>
    {
        public VisitStatusMap()
        {
            // Primary Key
            HasKey(t => t.VisitStatusId);

            // Properties
            Property(t => t.VisitStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.AdminName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.ClientName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.AssessorName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("VisitStatus");
            Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            Property(t => t.AdminName).HasColumnName("AdminName");
            Property(t => t.ClientName).HasColumnName("Name");
            Property(t => t.AssessorName).HasColumnName("AssessorName");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
