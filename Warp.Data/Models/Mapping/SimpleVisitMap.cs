using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SimpleVisitMap : EntityTypeConfiguration<SimpleVisit>
    {
        public SimpleVisitMap()
        {
            // Primary Key
            this.HasKey(t => t.SimpleVisitID);

            // Properties
            this.Property(t => t.SimpleVisitID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SimpleVisit");
            this.Property(t => t.SimpleVisitID).HasColumnName("SimpleVisitID");
            this.Property(t => t.SimpleVisitTemplateID).HasColumnName("SimpleVisitTemplateID");
            this.Property(t => t.VisitStatusID).HasColumnName("VisitStatusID");
            this.Property(t => t.VisitTypeID).HasColumnName("VisitTypeID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.SimpleVisitTemplate)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.SimpleVisitTemplateID);
            this.HasRequired(t => t.VisitStatu)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.VisitStatusID);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.SimpleVisits)
                .HasForeignKey(d => d.VisitTypeID);

        }
    }
}
