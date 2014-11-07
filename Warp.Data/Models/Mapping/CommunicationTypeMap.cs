using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CommunicationTypeMap : EntityTypeConfiguration<CommunicationType>
    {
        public CommunicationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CommunicationTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommunicationType");
            this.Property(t => t.CommunicationTypeID).HasColumnName("CommunicationTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
