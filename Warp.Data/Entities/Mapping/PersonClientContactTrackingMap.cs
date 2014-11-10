using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PersonClientContactTrackingMap : EntityTypeConfiguration<PersonClientContactTracking>
    {
        public PersonClientContactTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonClientContactTrackingID);

            // Properties
            this.Property(t => t.PersonClientContactTrackingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonClientContactTracking");
            this.Property(t => t.PersonClientContactTrackingID).HasColumnName("PersonClientContactTrackingID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.ClientContactTrackingID).HasColumnName("ClientContactTrackingID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.PersonClientContactTrackings)
                .HasForeignKey(d => d.ClientContactTrackingID);

        }
    }
}
