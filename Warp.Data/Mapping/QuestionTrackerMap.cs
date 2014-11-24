using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionTrackerMap : EntityTypeConfiguration<QuestionTracker>
    {
        public QuestionTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionTrackerId);

            // Properties
            this.Property(t => t.QuestionTrackerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionTracker");
            this.Property(t => t.QuestionTrackerId).HasColumnName("QuestionTrackerID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.MasterQuestionId).HasColumnName("MasterQuestionID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.ChildQuestionId).HasColumnName("ChildQuestionID");
            this.Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            this.Property(t => t.RemovedByAdminId).HasColumnName("RemovedByAdminID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Client)
                .WithMany(t => t.QuestionTrackers)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionTrackers)
                .HasForeignKey(d => d.MasterQuestionId);
            this.HasRequired(t => t.Question1)
                .WithMany(t => t.QuestionTrackers1)
                .HasForeignKey(d => d.ChildQuestionId);

        }
    }
}
