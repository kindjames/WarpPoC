using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportRestrictionClientMap : EntityTypeConfiguration<ReportRestrictionClient>
    {
        public ReportRestrictionClientMap()
        {
            // Primary Key
            HasKey(t => t.ReportRestrictionClientId);

            // Properties
            // Table & Column Mappings
            ToTable("ReportRestrictionClient", "Reporting");
            Property(t => t.ReportRestrictionClientId).HasColumnName("ReportRestrictionClientId");
            Property(t => t.ReportId).HasColumnName("ReportId");
            Property(t => t.ClientId).HasColumnName("ClientId");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.CreatedByUserRoleId).HasColumnName("CreatedByUserRoleId");
            Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            Property(t => t.RemovedByUserRoleId).HasColumnName("RemovedByUserRoleId");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.UserRole)
                .WithMany(t => t.ReportRestrictionClients)
                .HasForeignKey(d => d.CreatedByUserRoleId);
            HasRequired(t => t.Client)
                .WithMany(t => t.ReportRestrictionClients)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Report)
                .WithMany(t => t.ReportRestrictionClients)
                .HasForeignKey(d => d.ReportId);

        }
    }
}
