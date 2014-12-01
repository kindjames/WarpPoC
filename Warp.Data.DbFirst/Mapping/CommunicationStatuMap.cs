using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CommunicationStatusMap : EntityTypeConfiguration<CommunicationStatus>
    {
        public CommunicationStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.CommunicationStatusId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommunicationStatus");
            this.Property(t => t.CommunicationStatusId).HasColumnName("CommunicationStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
