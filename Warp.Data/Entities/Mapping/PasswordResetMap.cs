using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PasswordResetMap : EntityTypeConfiguration<PasswordReset>
    {
        public PasswordResetMap()
        {
            // Primary Key
            this.HasKey(t => t.PasswordResetID);

            // Properties
            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Token)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PasswordReset", "Account");
            this.Property(t => t.PasswordResetID).HasColumnName("PasswordResetID");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Successful).HasColumnName("Successful");
            this.Property(t => t.Token).HasColumnName("Token");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
