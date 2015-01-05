using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TourUserRoleMap : EntityTypeConfiguration<TourUserRole>
    {
        public TourUserRoleMap()
        {
            // Primary Key
            HasKey(t => t.TourUserRoleId);

            // Properties
            Property(t => t.SessionId)
                .IsRequired();

            // Table & Column Mappings
            ToTable("TourUserRole", "Help");
            Property(t => t.TourUserRoleId).HasColumnName("TourUserRoleID");
            Property(t => t.TourId).HasColumnName("TourID");
            Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            Property(t => t.HasViewedTour).HasColumnName("HasViewedTour");
            Property(t => t.PermanentlySkipTour).HasColumnName("PermanentlySkipTour");
            Property(t => t.DelayTourTillNextLogin).HasColumnName("DelayTourTillNextLogin");
            Property(t => t.SessionId).HasColumnName("SessionId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.UserRole)
                .WithMany(t => t.TourUserRoles)
                .HasForeignKey(d => d.UserRoleId);
            HasRequired(t => t.Tour)
                .WithMany(t => t.TourUserRoles)
                .HasForeignKey(d => d.TourId);

        }
    }
}
