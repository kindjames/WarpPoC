using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CustomerUserMap : EntityTypeConfiguration<CustomerUser>
    {
        public CustomerUserMap()
        {
            // Primary Key
            HasKey(t => t.CustomerUserId);

            // Properties
            // Table & Column Mappings
            ToTable("CustomerUser");
            Property(t => t.CustomerUserId).HasColumnName("CustomerUserID");
            Property(t => t.CustomerId).HasColumnName("CustomerID");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.CustomerLinkStatusId).HasColumnName("CustomerLinkStatusID");
            Property(t => t.PrimaryCustomer).HasColumnName("PrimaryCustomer");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.CustomerUsers)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.Customer)
                .WithMany(t => t.CustomerUsers)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
