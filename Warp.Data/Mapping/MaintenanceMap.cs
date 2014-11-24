using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MaintenanceMap : EntityTypeConfiguration<Maintenance>
    {
        public MaintenanceMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintenanceId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Details)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.HyperlinkURL)
                .HasMaxLength(255);

            this.Property(t => t.HyperlinkText)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Maintenance");
            this.Property(t => t.MaintenanceId).HasColumnName("MaintenanceID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.MaintenanceCategoryId).HasColumnName("MaintenanceCategoryID");
            this.Property(t => t.DateDisplayFrom).HasColumnName("DateDisplayFrom");
            this.Property(t => t.DateDisplayTo).HasColumnName("DateDisplayTo");
            this.Property(t => t.HyperlinkURL).HasColumnName("HyperlinkURL");
            this.Property(t => t.HyperlinkText).HasColumnName("HyperlinkText");
            this.Property(t => t.RemovedBy).HasColumnName("RemovedBy");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.MaintenanceCategory)
                .WithMany(t => t.Maintenances)
                .HasForeignKey(d => d.MaintenanceCategoryId);

        }
    }
}
