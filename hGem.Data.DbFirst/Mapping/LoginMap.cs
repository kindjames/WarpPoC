using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            // Primary Key
            HasKey(t => t.LoginId);

            // Properties
            Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            ToTable("Login");
            Property(t => t.LoginId).HasColumnName("LoginID");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.Success).HasColumnName("Success");
            Property(t => t.IP).HasColumnName("IP");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
