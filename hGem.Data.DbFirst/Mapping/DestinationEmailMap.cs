using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DestinationEmailMap : EntityTypeConfiguration<DestinationEmail>
    {
        public DestinationEmailMap()
        {
            // Primary Key
            HasKey(t => t.DestinationEmailId);

            // Properties
            Property(t => t.Subject)
                .IsRequired();

            // Table & Column Mappings
            ToTable("DestinationEmail", "Subscriptions");
            Property(t => t.DestinationEmailId).HasColumnName("DestinationEmailId");
            Property(t => t.DestinationId).HasColumnName("DestinationId");
            Property(t => t.EmailTypeId).HasColumnName("EmailTypeId");
            Property(t => t.Subject).HasColumnName("Subject");
            Property(t => t.Message).HasColumnName("Message");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Destination)
                .WithMany(t => t.DestinationEmails)
                .HasForeignKey(d => d.DestinationId);

        }
    }
}
