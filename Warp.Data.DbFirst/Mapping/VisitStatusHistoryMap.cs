using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitStatusHistoryMap : EntityTypeConfiguration<VisitStatusHistory>
    {
        public VisitStatusHistoryMap()
        {
            // Primary Key
            HasKey(t => t.VisitStatusHistoryId);

            // Properties
            Property(t => t.VisitStatusHistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitStatusHistory");
            Property(t => t.VisitStatusHistoryId).HasColumnName("VisitStatusHistoryID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitStatusHistories)
                .HasForeignKey(d => d.VisitId);
            HasRequired(t => t.VisitStatus)
                .WithMany(t => t.VisitStatusHistories)
                .HasForeignKey(d => d.VisitStatusId);
            HasRequired(t => t.VisitStatus1)
                .WithMany(t => t.VisitStatusHistories1)
                .HasForeignKey(d => d.VisitStatusId);

        }
    }
}
