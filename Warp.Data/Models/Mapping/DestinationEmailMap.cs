using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class DestinationEmailMap : EntityTypeConfiguration<DestinationEmail>
    {
        public DestinationEmailMap()
        {
            // Primary Key
            this.HasKey(t => t.DestinationEmailId);

            // Properties
            this.Property(t => t.Subject)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DestinationEmail", "Subscriptions");
            this.Property(t => t.DestinationEmailId).HasColumnName("DestinationEmailId");
            this.Property(t => t.DestinationId).HasColumnName("DestinationId");
            this.Property(t => t.EmailTypeId).HasColumnName("EmailTypeId");
            this.Property(t => t.Subject).HasColumnName("Subject");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Destination)
                .WithMany(t => t.DestinationEmails)
                .HasForeignKey(d => d.DestinationId);

        }
    }
}
