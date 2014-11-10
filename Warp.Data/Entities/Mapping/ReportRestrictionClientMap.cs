using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ReportRestrictionClientMap : EntityTypeConfiguration<ReportRestrictionClient>
    {
        public ReportRestrictionClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportRestrictionClientId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ReportRestrictionClient", "Reporting");
            this.Property(t => t.ReportRestrictionClientId).HasColumnName("ReportRestrictionClientId");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.CreatedByUserRoleId).HasColumnName("CreatedByUserRoleId");
            this.Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            this.Property(t => t.RemovedByUserRoleId).HasColumnName("RemovedByUserRoleId");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.ReportRestrictionClients)
                .HasForeignKey(d => d.CreatedByUserRoleId);
            this.HasOptional(t => t.UserRole1)
                .WithMany(t => t.ReportRestrictionClients1)
                .HasForeignKey(d => d.RemovedByUserRoleId);
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ReportRestrictionClients)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Report)
                .WithMany(t => t.ReportRestrictionClients)
                .HasForeignKey(d => d.ReportId);

        }
    }
}
