using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CustomerUserMap : EntityTypeConfiguration<CustomerUser>
    {
        public CustomerUserMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerUserId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CustomerUser");
            this.Property(t => t.CustomerUserId).HasColumnName("CustomerUserID");
            this.Property(t => t.CustomerId).HasColumnName("CustomerID");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.CustomerLinkStatusId).HasColumnName("CustomerLinkStatusID");
            this.Property(t => t.PrimaryCustomer).HasColumnName("PrimaryCustomer");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.CustomerUsers)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.CustomerUsers)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
