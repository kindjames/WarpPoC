using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.Forename)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Surname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .IsRequired();

            this.Property(t => t.Salt)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PasswordAnswer)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Forename).HasColumnName("Forename");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Salt).HasColumnName("Salt");
            this.Property(t => t.LastPasswordChange).HasColumnName("LastPasswordChange");
            this.Property(t => t.ForcePasswordChange).HasColumnName("ForcePasswordChange");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.DefaultUserRoleID).HasColumnName("DefaultUserRoleID");
            this.Property(t => t.DefaultLanguageID).HasColumnName("DefaultLanguageID");
            this.Property(t => t.LegacyUserID).HasColumnName("LegacyUserID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.AutoCloseToast).HasColumnName("AutoCloseToast");
            this.Property(t => t.PasswordQuestionID).HasColumnName("PasswordQuestionID");
            this.Property(t => t.PasswordAnswer).HasColumnName("PasswordAnswer");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
        }
    }
}
