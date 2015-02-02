using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DestinationFTPMap : EntityTypeConfiguration<DestinationFTP>
    {
        public DestinationFTPMap()
        {
            // Primary Key
            HasKey(t => t.DestinationFTPId);

            // Properties
            Property(t => t.Host)
                .IsRequired()
                .HasMaxLength(2000);

            Property(t => t.Username)
                .HasMaxLength(150);

            Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.Path)
                .HasMaxLength(2000);

            // Table & Column Mappings
            ToTable("DestinationFTP", "Subscriptions");
            Property(t => t.DestinationFTPId).HasColumnName("DestinationFTPId");
            Property(t => t.DestinationId).HasColumnName("DestinationId");
            Property(t => t.Host).HasColumnName("Host");
            Property(t => t.Username).HasColumnName("Username");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.Path).HasColumnName("Path");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Destination)
                .WithMany(t => t.DestinationFTPs)
                .HasForeignKey(d => d.DestinationId);

        }
    }
}
