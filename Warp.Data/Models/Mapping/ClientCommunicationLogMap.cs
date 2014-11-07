using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientCommunicationLogMap : EntityTypeConfiguration<ClientCommunicationLog>
    {
        public ClientCommunicationLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientCommunicationLogID);

            // Properties
            this.Property(t => t.ClientCommunicationLogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Details)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ClientCommunicationLog");
            this.Property(t => t.ClientCommunicationLogID).HasColumnName("ClientCommunicationLogID");
            this.Property(t => t.CommunicationStatusID).HasColumnName("CommunicationStatusID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.CommunicationTypeID).HasColumnName("CommunicationTypeID");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CommunicationStatu)
                .WithMany(t => t.ClientCommunicationLogs)
                .HasForeignKey(d => d.CommunicationStatusID);
            this.HasRequired(t => t.CommunicationType)
                .WithMany(t => t.ClientCommunicationLogs)
                .HasForeignKey(d => d.CommunicationTypeID);

        }
    }
}
