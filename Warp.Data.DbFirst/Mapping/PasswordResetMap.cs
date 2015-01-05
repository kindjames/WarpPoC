using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PasswordResetMap : EntityTypeConfiguration<PasswordReset>
    {
        public PasswordResetMap()
        {
            // Primary Key
            HasKey(t => t.PasswordResetId);

            // Properties
            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.Token)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("PasswordReset", "Account");
            Property(t => t.PasswordResetId).HasColumnName("PasswordResetID");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Successful).HasColumnName("Successful");
            Property(t => t.Token).HasColumnName("Token");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
