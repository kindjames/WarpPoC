using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CommunicationPreferenceMap : EntityTypeConfiguration<CommunicationPreference>
    {
        public CommunicationPreferenceMap()
        {
            // Primary Key
            HasKey(t => t.CommunicationPreferencesId);

            // Properties
            Property(t => t.CommunicationPreferencesId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Notes)
                .HasMaxLength(300);

            // Table & Column Mappings
            ToTable("CommunicationPreference");
            Property(t => t.CommunicationPreferencesId).HasColumnName("CommunicationPreferencesID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.CommunicationTypeId).HasColumnName("CommunicationTypeID");
            Property(t => t.ScoreGreaterThanCondition).HasColumnName("ScoreGreaterThanCondition");
            Property(t => t.ScoreLessThanCondition).HasColumnName("ScoreLessThanCondition");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.CommunicationPreferences)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.CommunicationType)
                .WithMany(t => t.CommunicationPreferences)
                .HasForeignKey(d => d.CommunicationTypeId);

        }
    }
}
