using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CommunicationStatusMap : EntityTypeConfiguration<CommunicationStatus>
    {
        public CommunicationStatusMap()
        {
            // Primary Key
            HasKey(t => t.CommunicationStatusId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("CommunicationStatus");
            Property(t => t.CommunicationStatusId).HasColumnName("CommunicationStatusID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
