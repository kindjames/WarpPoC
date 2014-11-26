using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TourUserRoleMap : EntityTypeConfiguration<TourUserRole>
    {
        public TourUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.TourUserRoleId);

            // Properties
            this.Property(t => t.SessionId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("TourUserRole", "Help");
            this.Property(t => t.TourUserRoleId).HasColumnName("TourUserRoleID");
            this.Property(t => t.TourId).HasColumnName("TourID");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            this.Property(t => t.HasViewedTour).HasColumnName("HasViewedTour");
            this.Property(t => t.PermanentlySkipTour).HasColumnName("PermanentlySkipTour");
            this.Property(t => t.DelayTourTillNextLogin).HasColumnName("DelayTourTillNextLogin");
            this.Property(t => t.SessionId).HasColumnName("SessionId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.TourUserRoles)
                .HasForeignKey(d => d.UserRoleId);
            this.HasRequired(t => t.Tour)
                .WithMany(t => t.TourUserRoles)
                .HasForeignKey(d => d.TourId);

        }
    }
}
