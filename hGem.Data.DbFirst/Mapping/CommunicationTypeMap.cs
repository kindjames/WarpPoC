using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CommunicationTypeMap : EntityTypeConfiguration<CommunicationType>
    {
        public CommunicationTypeMap()
        {
            // Primary Key
            HasKey(t => t.CommunicationTypeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("CommunicationType");
            Property(t => t.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
