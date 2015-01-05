using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class Messages_0_IdMap : EntityTypeConfiguration<Messages_0_Id>
    {
        public Messages_0_IdMap()
        {
            // Primary Key
            HasKey(t => t.PayloadId);

            // Properties
            Property(t => t.PayloadId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Messages_0_Id", "SignalR");
            Property(t => t.PayloadId).HasColumnName("PayloadId");
        }
    }
}
