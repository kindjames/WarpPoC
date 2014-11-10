using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BanClientMap : EntityTypeConfiguration<BanClient>
    {
        public BanClientMap()
        {
            // Primary Key
            this.HasKey(t => t.BanClientID);

            // Properties
            this.Property(t => t.BanClientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BanClient");
            this.Property(t => t.BanClientID).HasColumnName("BanClientID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.BanClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.BanClients)
                .HasForeignKey(d => d.AssessorID);

        }
    }
}
