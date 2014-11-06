using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientContactTrackingMap : EntityTypeConfiguration<ClientContactTracking>
    {
        public ClientContactTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientContactTrackingID);

            // Properties
            this.Property(t => t.ClientContactTrackingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AddedByAdminID)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ClientContactTracking");
            this.Property(t => t.ClientContactTrackingID).HasColumnName("ClientContactTrackingID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.ContactTypeID).HasColumnName("ContactTypeID");
            this.Property(t => t.ClientContactStatusID).HasColumnName("ClientContactStatusID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientContactTrackings)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.ClientContactStatu)
                .WithMany(t => t.ClientContactTrackings)
                .HasForeignKey(d => d.ClientContactStatusID);

        }
    }
}
