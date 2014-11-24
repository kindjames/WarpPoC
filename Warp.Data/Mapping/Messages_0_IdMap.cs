using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class Messages_0_IdMap : EntityTypeConfiguration<Messages_0_Id>
    {
        public Messages_0_IdMap()
        {
            // Primary Key
            this.HasKey(t => t.PayloadId);

            // Properties
            this.Property(t => t.PayloadId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Messages_0_Id", "SignalR");
            this.Property(t => t.PayloadId).HasColumnName("PayloadId");
        }
    }
}
