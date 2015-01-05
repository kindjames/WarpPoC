using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientCommunicationLogMap : EntityTypeConfiguration<ClientCommunicationLog>
    {
        public ClientCommunicationLogMap()
        {
            // Primary Key
            HasKey(t => t.ClientCommunicationLogId);

            // Properties
            Property(t => t.ClientCommunicationLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Details)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("ClientCommunicationLog");
            Property(t => t.ClientCommunicationLogId).HasColumnName("ClientCommunicationLogID");
            Property(t => t.CommunicationStatusId).HasColumnName("CommunicationStatusID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            Property(t => t.Details).HasColumnName("Details");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.CommunicationStatus)
                .WithMany(t => t.ClientCommunicationLogs)
                .HasForeignKey(d => d.CommunicationStatusId);
            HasRequired(t => t.CommunicationType)
                .WithMany(t => t.ClientCommunicationLogs)
                .HasForeignKey(d => d.CommunicationTypeId);

        }
    }
}
