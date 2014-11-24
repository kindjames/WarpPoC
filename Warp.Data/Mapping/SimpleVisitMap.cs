using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SimpleVisitMap : EntityTypeConfiguration<SimpleVisit>
    {
        public SimpleVisitMap()
        {
            // Primary Key
            this.HasKey(t => t.SimpleVisitId);

            // Properties
            this.Property(t => t.SimpleVisitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SimpleVisit");
            this.Property(t => t.SimpleVisitId).HasColumnName("SimpleVisitID");
            this.Property(t => t.SimpleVisitTemplateId).HasColumnName("SimpleVisitTemplateID");
            this.Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            this.Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.SimpleVisitTemplate)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.SimpleVisitTemplateId);
            this.HasRequired(t => t.VisitStatus)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.VisitStatusId);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
