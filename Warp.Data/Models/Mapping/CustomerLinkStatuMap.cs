using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CustomerLinkStatuMap : EntityTypeConfiguration<CustomerLinkStatu>
    {
        public CustomerLinkStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerLinkStatusID);

            // Properties
            this.Property(t => t.CustomerLinkStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CustomerLinkStatus");
            this.Property(t => t.CustomerLinkStatusID).HasColumnName("CustomerLinkStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
