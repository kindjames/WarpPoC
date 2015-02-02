using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MaintenanceMap : EntityTypeConfiguration<Maintenance>
    {
        public MaintenanceMap()
        {
            // Primary Key
            HasKey(t => t.MaintenanceId);

            // Properties
            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.Details)
                .IsRequired()
                .HasMaxLength(2000);

            Property(t => t.HyperlinkURL)
                .HasMaxLength(255);

            Property(t => t.HyperlinkText)
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("Maintenance");
            Property(t => t.MaintenanceId).HasColumnName("MaintenanceID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Details).HasColumnName("Details");
            Property(t => t.MaintenanceCategoryId).HasColumnName("MaintenanceCategoryID");
            Property(t => t.DateDisplayFrom).HasColumnName("DateDisplayFrom");
            Property(t => t.DateDisplayTo).HasColumnName("DateDisplayTo");
            Property(t => t.HyperlinkURL).HasColumnName("HyperlinkURL");
            Property(t => t.HyperlinkText).HasColumnName("HyperlinkText");
            Property(t => t.RemovedBy).HasColumnName("RemovedBy");
            Property(t => t.AddedBy).HasColumnName("AddedBy");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.MaintenanceCategory)
                .WithMany(t => t.Maintenances)
                .HasForeignKey(d => d.MaintenanceCategoryId);

        }
    }
}
