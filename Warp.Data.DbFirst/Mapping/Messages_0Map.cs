using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class Messages_0Map : EntityTypeConfiguration<Messages_0>
    {
        public Messages_0Map()
        {
            // Primary Key
            this.HasKey(t => t.PayloadId);

            // Properties
            this.Property(t => t.PayloadId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Payload)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Messages_0", "SignalR");
            this.Property(t => t.PayloadId).HasColumnName("PayloadId");
            this.Property(t => t.Payload).HasColumnName("Payload");
            this.Property(t => t.InsertedOn).HasColumnName("InsertedOn");
        }
    }
}
