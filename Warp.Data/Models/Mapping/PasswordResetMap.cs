using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
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
            this.ToTable("PasswordReset");
            this.Property(t => t.PasswordResetID).HasColumnName("PasswordResetID");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Successful).HasColumnName("Successful");
            this.Property(t => t.Token).HasColumnName("Token");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
        }
    }
}
