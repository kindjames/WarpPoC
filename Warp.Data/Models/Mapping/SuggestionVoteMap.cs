using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SuggestionVoteMap : EntityTypeConfiguration<SuggestionVote>
    {
        public SuggestionVoteMap()
        {
            // Primary Key
            this.HasKey(t => t.SuggestionVoteID);

            // Properties
            this.Property(t => t.SuggestionVoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SuggestionVote");
            this.Property(t => t.SuggestionVoteID).HasColumnName("SuggestionVoteID");
            this.Property(t => t.SuggestionID).HasColumnName("SuggestionID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.DateOfVote).HasColumnName("DateOfVote");
            this.Property(t => t.Vote).HasColumnName("Vote");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.SuggestionVotes)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.Suggestion)
                .WithMany(t => t.SuggestionVotes)
                .HasForeignKey(d => d.SuggestionID);

        }
    }
}
