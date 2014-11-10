using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class VisitStatuMap : EntityTypeConfiguration<VisitStatu>
    {
        public VisitStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitStatusID);

            // Properties
            this.Property(t => t.VisitStatusID)
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
            this.Property(t => t.VisitStatusID).HasColumnName("VisitStatusID");
            this.Property(t => t.AdminName).HasColumnName("AdminName");
            this.Property(t => t.ClientName).HasColumnName("ClientName");
            this.Property(t => t.AssessorName).HasColumnName("AssessorName");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
