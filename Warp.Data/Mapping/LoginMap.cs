using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            // Primary Key
            this.HasKey(t => t.LoginId);

            // Properties
            this.Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Login");
            this.Property(t => t.LoginId).HasColumnName("LoginID");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.Success).HasColumnName("Success");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
