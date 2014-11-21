using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientHistoryMap : EntityTypeConfiguration<ClientHistory>
    {
        public ClientHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientHistoryId);

            // Properties
            this.Property(t => t.ClientName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ClientHistory", "Client");
            this.Property(t => t.ClientHistoryId).HasColumnName("ClientHistoryID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.ClientStatusId).HasColumnName("ClientStatusID");
            this.Property(t => t.ClientName).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientHistories)
                .HasForeignKey(d => d.ClientId);

            this.HasRequired(t => t.ClientStatus)
                .WithMany(t => t.ClientHistories)
                .HasForeignKey(d => d.ClientStatusId);

        }
    }
}
