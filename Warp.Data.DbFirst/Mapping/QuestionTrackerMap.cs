using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionTrackerMap : EntityTypeConfiguration<QuestionTracker>
    {
        public QuestionTrackerMap()
        {
            // Primary Key
            HasKey(t => t.QuestionTrackerId);

            // Properties
            Property(t => t.QuestionTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("QuestionTracker");
            Property(t => t.QuestionTrackerId).HasColumnName("QuestionTrackerID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.MasterQuestionId).HasColumnName("MasterQuestionID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.ChildQuestionId).HasColumnName("ChildQuestionID");
            Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            Property(t => t.RemovedByAdminId).HasColumnName("RemovedByAdminID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Client)
                .WithMany(t => t.QuestionTrackers)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Question)
                .WithMany(t => t.QuestionTrackers)
                .HasForeignKey(d => d.MasterQuestionId);
            HasRequired(t => t.Question1)
                .WithMany(t => t.QuestionTrackers1)
                .HasForeignKey(d => d.ChildQuestionId);

        }
    }
}
