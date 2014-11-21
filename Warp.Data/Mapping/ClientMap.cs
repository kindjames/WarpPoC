using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Client", "Client");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ClientStatusId).HasColumnName("ClientStatusID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.CustomerId).HasColumnName("CustomerID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");

            // Relationships
            this.HasRequired(t => t.ClientStatus)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.ClientStatusId);
        }
    }
}
