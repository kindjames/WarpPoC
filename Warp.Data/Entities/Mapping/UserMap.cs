using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
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

            this.Property(t => t.ProvidorName)
                .HasMaxLength(250);

            this.Property(t => t.ProvidorUserKey)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.UserName)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("User", "Account");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Forename).HasColumnName("Forename");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Salt).HasColumnName("Salt");
            this.Property(t => t.DateLastPasswordChange).HasColumnName("DateLastPasswordChange");
            this.Property(t => t.ForcePasswordChange).HasColumnName("ForcePasswordChange");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.DefaultUserRoleID).HasColumnName("DefaultUserRoleID");
            this.Property(t => t.DefaultLanguageID).HasColumnName("DefaultLanguageID");
            this.Property(t => t.LegacyUserID).HasColumnName("LegacyUserID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.AutoCloseToast).HasColumnName("AutoCloseToast");
            this.Property(t => t.PasswordQuestionID).HasColumnName("PasswordQuestionID");
            this.Property(t => t.PasswordAnswer).HasColumnName("PasswordAnswer");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateOfLastActivity).HasColumnName("DateOfLastActivity");
            this.Property(t => t.DateLastLockedOut).HasColumnName("DateLastLockedOut");
            this.Property(t => t.DateLastLoggedIn).HasColumnName("DateLastLoggedIn");
            this.Property(t => t.IsApproved).HasColumnName("IsApproved");
            this.Property(t => t.IsLockedOut).HasColumnName("IsLockedOut");
            this.Property(t => t.ProvidorName).HasColumnName("ProvidorName");
            this.Property(t => t.ProvidorUserKey).HasColumnName("ProvidorUserKey");
            this.Property(t => t.UserName).HasColumnName("UserName");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CustomerID);

        }
    }
}
