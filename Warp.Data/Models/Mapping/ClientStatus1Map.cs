using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientStatus1Map : EntityTypeConfiguration<ClientStatus1>
    {
        public ClientStatus1Map()
        {
            // Primary Key
            this.HasKey(t => t.ClientStatusID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ClientStatus");
            this.Property(t => t.ClientStatusID).HasColumnName("ClientStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
