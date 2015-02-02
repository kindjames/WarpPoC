using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientHistoryMap : EntityTypeConfiguration<ClientHistory>
    {
        public ClientHistoryMap()
        {
            // Primary Key
            HasKey(t => t.ClientHistoryId);

            // Properties
            Property(t => t.ClientName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("ClientHistory", "Client");
            Property(t => t.ClientHistoryId).HasColumnName("ClientHistoryID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.ClientStatusId).HasColumnName("ClientStatusID");
            Property(t => t.ClientName).HasColumnName("Name");
            Property(t => t.Code).HasColumnName("Code");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientHistories)
                .HasForeignKey(d => d.ClientId);

            HasRequired(t => t.ClientStatus)
                .WithMany(t => t.ClientHistories)
                .HasForeignKey(d => d.ClientStatusId);

        }
    }
}
