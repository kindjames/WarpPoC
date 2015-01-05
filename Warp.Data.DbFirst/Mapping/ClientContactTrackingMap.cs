using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientContactTrackingMap : EntityTypeConfiguration<ClientContactTracking>
    {
        public ClientContactTrackingMap()
        {
            // Primary Key
            HasKey(t => t.ClientContactTrackingId);

            // Properties
            Property(t => t.ClientContactTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.AddedByAdminId)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("ClientContactTracking");
            Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.ContactTypeId).HasColumnName("ContactTypeID");
            Property(t => t.ClientContactStatusId).HasColumnName("ClientContactStatusID");
            Property(t => t.DateOfContact).HasColumnName("DateOfContact");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientContactTrackings)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.ClientContactStatus)
                .WithMany(t => t.ClientContactTrackings)
                .HasForeignKey(d => d.ClientContactStatusId);

        }
    }
}
