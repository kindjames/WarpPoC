using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SimpleVisitMap : EntityTypeConfiguration<SimpleVisit>
    {
        public SimpleVisitMap()
        {
            // Primary Key
            HasKey(t => t.SimpleVisitId);

            // Properties
            Property(t => t.SimpleVisitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable("SimpleVisit");
            Property(t => t.SimpleVisitId).HasColumnName("SimpleVisitID");
            Property(t => t.SimpleVisitTemplateId).HasColumnName("SimpleVisitTemplateID");
            Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.IP).HasColumnName("IP");
            Property(t => t.StartTime).HasColumnName("StartTime");
            Property(t => t.EndTime).HasColumnName("EndTime");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.SimpleVisitTemplate)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.SimpleVisitTemplateId);
            HasRequired(t => t.VisitStatus)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.VisitStatusId);
            HasRequired(t => t.VisitType)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
