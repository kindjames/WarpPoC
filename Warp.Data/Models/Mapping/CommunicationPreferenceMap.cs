using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CommunicationPreferenceMap : EntityTypeConfiguration<CommunicationPreference>
    {
        public CommunicationPreferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.CommunicationPreferencesID);

            // Properties
            this.Property(t => t.CommunicationPreferencesID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("CommunicationPreference");
            this.Property(t => t.CommunicationPreferencesID).HasColumnName("CommunicationPreferencesID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.CommunicationTypeID).HasColumnName("CommunicationTypeID");
            this.Property(t => t.ScoreGreaterThanCondition).HasColumnName("ScoreGreaterThanCondition");
            this.Property(t => t.ScoreLessThanCondition).HasColumnName("ScoreLessThanCondition");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.CommunicationPreferences)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.CommunicationType)
                .WithMany(t => t.CommunicationPreferences)
                .HasForeignKey(d => d.CommunicationTypeID);

        }
    }
}
