using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitStatusMap : EntityTypeConfiguration<VisitStatus>
    {
        public VisitStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitStatusId);

            // Properties
            this.Property(t => t.VisitStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AdminName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ClientName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AssessorName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VisitStatus");
            this.Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            this.Property(t => t.AdminName).HasColumnName("AdminName");
            this.Property(t => t.ClientName).HasColumnName("Name");
            this.Property(t => t.AssessorName).HasColumnName("AssessorName");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
