using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class TourUserRoleMap : EntityTypeConfiguration<TourUserRole>
    {
        public TourUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.TourUserRoleID);

            // Properties
            this.Property(t => t.SessionId)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("TourUserRole", "Help");
            this.Property(t => t.TourUserRoleID).HasColumnName("TourUserRoleID");
            this.Property(t => t.TourID).HasColumnName("TourID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
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
                .HasForeignKey(d => d.UserRoleID);
            this.HasRequired(t => t.Tour)
                .WithMany(t => t.TourUserRoles)
                .HasForeignKey(d => d.TourID);

        }
    }
}
