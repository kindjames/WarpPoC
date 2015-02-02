using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DestinationFileShareMap : EntityTypeConfiguration<DestinationFileShare>
    {
        public DestinationFileShareMap()
        {
            // Primary Key
            HasKey(t => t.DestinationFileShareId);

            // Properties
            Property(t => t.CustomFilePath)
                .HasMaxLength(2000);

            Property(t => t.SpecificFolder)
                .HasMaxLength(2000);

            // Table & Column Mappings
            ToTable("DestinationFileShare", "Subscriptions");
            Property(t => t.DestinationFileShareId).HasColumnName("DestinationFileShareId");
            Property(t => t.DestinationId).HasColumnName("DestinationId");
            Property(t => t.FilepathLocationId).HasColumnName("FilepathLocationId");
            Property(t => t.CustomFilePath).HasColumnName("CustomFilePath");
            Property(t => t.SpecificFolder).HasColumnName("SpecificFolder");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Destination)
                .WithMany(t => t.DestinationFileShares)
                .HasForeignKey(d => d.DestinationId);

        }
    }
}
