using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            HasKey(t => t.ClientId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Code)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Client", "Client");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.ClientStatusId).HasColumnName("ClientStatusID");
            Property(t => t.Code).HasColumnName("Code");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.CustomerId).HasColumnName("CustomerID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");

            // Relationships
            HasRequired(t => t.ClientStatus)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.ClientStatusId);
        }
    }
}
