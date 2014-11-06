using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientHistoryMap : EntityTypeConfiguration<ClientHistory>
    {
        public ClientHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientHistoryID);

            // Properties
            this.Property(t => t.ClientHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClientName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ClientHistory");
            this.Property(t => t.ClientHistoryID).HasColumnName("ClientHistoryID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.ClientStatusID).HasColumnName("ClientStatusID");
            this.Property(t => t.ClientName).HasColumnName("ClientName");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientHistories)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.ClientStatu)
                .WithMany(t => t.ClientHistories)
                .HasForeignKey(d => d.ClientStatusID);

        }
    }
}
