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
            HasKey(t => t.PayloadId);

            // Properties
            Property(t => t.PayloadId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Payload)
                .IsRequired();

            // Table & Column Mappings
            ToTable("Messages_0", "SignalR");
            Property(t => t.PayloadId).HasColumnName("PayloadId");
            Property(t => t.Payload).HasColumnName("Payload");
            Property(t => t.InsertedOn).HasColumnName("InsertedOn");
        }
    }
}
