using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.Forename)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Surname)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.PasswordHash)
                .IsRequired();

            Property(t => t.Salt)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.PasswordAnswer)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("User", "Account");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.Forename).HasColumnName("Forename");
            Property(t => t.Surname).HasColumnName("Surname");
            Property(t => t.PasswordHash).HasColumnName("Password");
            Property(t => t.Salt).HasColumnName("Salt");
            Property(t => t.DateLastPasswordChange).HasColumnName("DateLastPasswordChange");
            Property(t => t.ForcePasswordChange).HasColumnName("ForcePasswordChange");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.CustomerId).HasColumnName("CustomerID");
            Property(t => t.DefaultUserRoleId).HasColumnName("DefaultUserRoleID");
            Property(t => t.DefaultLanguageId).HasColumnName("DefaultLanguageID");
            Property(t => t.LegacyUserId).HasColumnName("LegacyUserID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.AutoCloseToast).HasColumnName("AutoCloseToast");
            Property(t => t.PasswordQuestionId).HasColumnName("PasswordQuestionID");
            Property(t => t.PasswordAnswer).HasColumnName("PasswordAnswer");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateOfLastActivity).HasColumnName("DateOfLastActivity");
            Property(t => t.DateLastLockedOut).HasColumnName("DateLastLockedOut");
            Property(t => t.DateLastLoggedIn).HasColumnName("DateLastLoggedIn");
            Property(t => t.IsApproved).HasColumnName("IsApproved");
            Property(t => t.IsLockedOut).HasColumnName("IsLockedOut");

            // Relationships
            HasRequired(t => t.Customer)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CustomerId);

            HasMany(s => s.Roles)
                .WithMany(c => c.Users)
                .Map(c =>
                {
                    c.MapLeftKey("UserID");
                    c.MapRightKey("RoleID");
                    c.ToTable("UserRole");
                });
        }
    }
}
