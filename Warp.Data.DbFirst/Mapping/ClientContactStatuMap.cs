using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientContactStatusMap : EntityTypeConfiguration<ClientContactStatus>
    {
        public ClientContactStatusMap()
        {
            // Primary Key
            HasKey(t => t.ClientContactStatusId);

            // Properties
            Property(t => t.ClientContactStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("ClientContactStatus", "Client");
            Property(t => t.ClientContactStatusId).HasColumnName("ClientContactStatusID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
