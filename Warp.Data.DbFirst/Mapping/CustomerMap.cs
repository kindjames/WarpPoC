using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerId);

            // Properties
            this.Property(t => t.CustomerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.UrlName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CustomerCode)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Customer");
            this.Property(t => t.CustomerId).HasColumnName("CustomerID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UrlName).HasColumnName("UrlName");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.CustomerCode).HasColumnName("CustomerCode");
            this.Property(t => t.DefaultLanguageId).HasColumnName("DefaultLanguageID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
