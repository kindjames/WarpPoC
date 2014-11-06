using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerClientMap : EntityTypeConfiguration<ManagerClient>
    {
        public ManagerClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerClientID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ManagerClient");
            this.Property(t => t.ManagerClientID).HasColumnName("ManagerClientID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");

            // Relationships
            this.HasRequired(t => t.Client1)
                .WithMany(t => t.ManagerClients)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
