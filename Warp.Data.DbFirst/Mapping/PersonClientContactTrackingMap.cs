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
            HasKey(t => t.PersonClientContactTrackingId);

            // Properties
            Property(t => t.PersonClientContactTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("PersonClientContactTracking");
            Property(t => t.PersonClientContactTrackingId).HasColumnName("PersonClientContactTrackingID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.PersonClientContactTrackings)
                .HasForeignKey(d => d.ClientContactTrackingId);

        }
    }
}
