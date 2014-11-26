using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonClientContactTrackingMap : EntityTypeConfiguration<PersonClientContactTracking>
    {
        public PersonClientContactTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonClientContactTrackingId);

            // Properties
            this.Property(t => t.PersonClientContactTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonClientContactTracking");
            this.Property(t => t.PersonClientContactTrackingId).HasColumnName("PersonClientContactTrackingID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.PersonClientContactTrackings)
                .HasForeignKey(d => d.ClientContactTrackingId);

        }
    }
}
