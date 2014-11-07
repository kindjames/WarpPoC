using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CustomerUserMap : EntityTypeConfiguration<CustomerUser>
    {
        public CustomerUserMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerUserID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CustomerUser");
            this.Property(t => t.CustomerUserID).HasColumnName("CustomerUserID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.CustomerLinkStatusID).HasColumnName("CustomerLinkStatusID");
            this.Property(t => t.PrimaryCustomer).HasColumnName("PrimaryCustomer");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.CustomerUsers)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.CustomerUsers)
                .HasForeignKey(d => d.CustomerID);

        }
    }
}
