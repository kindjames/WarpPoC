using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class EmailRecipientMap : EntityTypeConfiguration<EmailRecipient>
    {
        public EmailRecipientMap()
        {
            // Primary Key
            this.HasKey(t => t.EmailRecipientId);

            // Properties
            // Table & Column Mappings
            this.ToTable("EmailRecipient", "Subscriptions");
            this.Property(t => t.EmailRecipientId).HasColumnName("EmailRecipientId");
            this.Property(t => t.DestinationEmailId).HasColumnName("DestinationEmailId");
            this.Property(t => t.UserUId).HasColumnName("UserUId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.DestinationEmail)
                .WithMany(t => t.EmailRecipients)
                .HasForeignKey(d => d.DestinationEmailId);

        }
    }
}
