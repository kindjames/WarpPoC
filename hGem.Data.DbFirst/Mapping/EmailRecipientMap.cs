using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class EmailRecipientMap : EntityTypeConfiguration<EmailRecipient>
    {
        public EmailRecipientMap()
        {
            // Primary Key
            HasKey(t => t.EmailRecipientId);

            // Properties
            // Table & Column Mappings
            ToTable("EmailRecipient", "Subscriptions");
            Property(t => t.EmailRecipientId).HasColumnName("EmailRecipientId");
            Property(t => t.DestinationEmailId).HasColumnName("DestinationEmailId");
            Property(t => t.UserUId).HasColumnName("UserUId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.DestinationEmail)
                .WithMany(t => t.EmailRecipients)
                .HasForeignKey(d => d.DestinationEmailId);

        }
    }
}
