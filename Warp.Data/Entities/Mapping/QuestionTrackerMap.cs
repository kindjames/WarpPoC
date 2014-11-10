using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class QuestionTrackerMap : EntityTypeConfiguration<QuestionTracker>
    {
        public QuestionTrackerMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionTrackerID);

            // Properties
            this.Property(t => t.QuestionTrackerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionTracker");
            this.Property(t => t.QuestionTrackerID).HasColumnName("QuestionTrackerID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.MasterQuestionID).HasColumnName("MasterQuestionID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.ChildQuestionID).HasColumnName("ChildQuestionID");
            this.Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            this.Property(t => t.RemovedByAdminID).HasColumnName("RemovedByAdminID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Client)
                .WithMany(t => t.QuestionTrackers)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionTrackers)
                .HasForeignKey(d => d.MasterQuestionID);
            this.HasRequired(t => t.Question1)
                .WithMany(t => t.QuestionTrackers1)
                .HasForeignKey(d => d.ChildQuestionID);

        }
    }
}
