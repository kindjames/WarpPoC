using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CommunicationStatuMap : EntityTypeConfiguration<CommunicationStatu>
    {
        public CommunicationStatuMap()
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
