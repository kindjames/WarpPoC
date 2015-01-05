using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CustomerLinkStatusMap : EntityTypeConfiguration<CustomerLinkStatus>
    {
        public CustomerLinkStatusMap()
        {
            // Primary Key
            HasKey(t => t.CustomerLinkStatusId);

            // Properties
            Property(t => t.CustomerLinkStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("CustomerLinkStatus");
            Property(t => t.CustomerLinkStatusId).HasColumnName("CustomerLinkStatusID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
