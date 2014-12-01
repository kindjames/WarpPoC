using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DestinationFileShareMap : EntityTypeConfiguration<DestinationFileShare>
    {
        public DestinationFileShareMap()
        {
            // Primary Key
            this.HasKey(t => t.DestinationFileShareId);

            // Properties
            this.Property(t => t.CustomFilePath)
                .HasMaxLength(2000);

            this.Property(t => t.SpecificFolder)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("DestinationFileShare", "Subscriptions");
            this.Property(t => t.DestinationFileShareId).HasColumnName("DestinationFileShareId");
            this.Property(t => t.DestinationId).HasColumnName("DestinationId");
            this.Property(t => t.FilepathLocationId).HasColumnName("FilepathLocationId");
            this.Property(t => t.CustomFilePath).HasColumnName("CustomFilePath");
            this.Property(t => t.SpecificFolder).HasColumnName("SpecificFolder");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Destination)
                .WithMany(t => t.DestinationFileShares)
                .HasForeignKey(d => d.DestinationId);

        }
    }
}
