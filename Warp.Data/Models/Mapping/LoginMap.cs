using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            // Primary Key
            this.HasKey(t => t.LoginID);

            // Properties
            this.Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Login");
            this.Property(t => t.LoginID).HasColumnName("LoginID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Success).HasColumnName("Success");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
