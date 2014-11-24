using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CustomerLinkStatusMap : EntityTypeConfiguration<CustomerLinkStatus>
    {
        public CustomerLinkStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerLinkStatusId);

            // Properties
            this.Property(t => t.CustomerLinkStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CustomerLinkStatus");
            this.Property(t => t.CustomerLinkStatusId).HasColumnName("CustomerLinkStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
