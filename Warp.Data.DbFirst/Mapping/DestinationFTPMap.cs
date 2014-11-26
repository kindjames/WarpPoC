using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DestinationFTPMap : EntityTypeConfiguration<DestinationFTP>
    {
        public DestinationFTPMap()
        {
            // Primary Key
            this.HasKey(t => t.DestinationFTPId);

            // Properties
            this.Property(t => t.Host)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Username)
                .HasMaxLength(150);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Path)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("DestinationFTP", "Subscriptions");
            this.Property(t => t.DestinationFTPId).HasColumnName("DestinationFTPId");
            this.Property(t => t.DestinationId).HasColumnName("DestinationId");
            this.Property(t => t.Host).HasColumnName("Host");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Destination)
                .WithMany(t => t.DestinationFTPs)
                .HasForeignKey(d => d.DestinationId);

        }
    }
}
