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
            HasKey(t => t.CustomerId);

            // Properties
            Property(t => t.CustomerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.UrlName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.CustomerCode)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            ToTable("CustomerId");
            Property(t => t.CustomerId).HasColumnName("CustomerID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.UrlName).HasColumnName("UrlName");
            Property(t => t.DisplayName).HasColumnName("DisplayName");
            Property(t => t.CustomerCode).HasColumnName("CustomerCode");
            Property(t => t.DefaultLanguageId).HasColumnName("DefaultLanguageID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
