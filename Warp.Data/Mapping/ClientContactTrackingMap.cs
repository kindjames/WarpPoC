using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientContactTrackingMap : EntityTypeConfiguration<ClientContactTracking>
    {
        public ClientContactTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientContactTrackingId);

            // Properties
            this.Property(t => t.ClientContactTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AddedByAdminId)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ClientContactTracking");
            this.Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.ContactTypeId).HasColumnName("ContactTypeID");
            this.Property(t => t.ClientContactStatusId).HasColumnName("ClientContactStatusID");
            this.Property(t => t.DateOfContact).HasColumnName("DateOfContact");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientContactTrackings)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.ClientContactStatus)
                .WithMany(t => t.ClientContactTrackings)
                .HasForeignKey(d => d.ClientContactStatusId);

        }
    }
}
