using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientContactStatus1Map : EntityTypeConfiguration<ClientContactStatus1>
    {
        public ClientContactStatus1Map()
        {
            // Primary Key
            this.HasKey(t => t.ClientContactStatusID);

            // Properties
            this.Property(t => t.ClientContactStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ClientContactStatus");
            this.Property(t => t.ClientContactStatusID).HasColumnName("ClientContactStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
