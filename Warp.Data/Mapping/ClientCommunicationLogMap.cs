using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientCommunicationLogMap : EntityTypeConfiguration<ClientCommunicationLog>
    {
        public ClientCommunicationLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientCommunicationLogId);

            // Properties
            this.Property(t => t.ClientCommunicationLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Details)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ClientCommunicationLog");
            this.Property(t => t.ClientCommunicationLogId).HasColumnName("ClientCommunicationLogID");
            this.Property(t => t.CommunicationStatusId).HasColumnName("CommunicationStatusID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            this.Property(t => t.Details).HasColumnName("Details");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CommunicationStatus)
                .WithMany(t => t.ClientCommunicationLogs)
                .HasForeignKey(d => d.CommunicationStatusId);
            this.HasRequired(t => t.CommunicationType)
                .WithMany(t => t.ClientCommunicationLogs)
                .HasForeignKey(d => d.CommunicationTypeId);

        }
    }
}
