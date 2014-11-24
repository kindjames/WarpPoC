using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SuggestionVoteMap : EntityTypeConfiguration<SuggestionVote>
    {
        public SuggestionVoteMap()
        {
            // Primary Key
            this.HasKey(t => t.SuggestionVoteId);

            // Properties
            this.Property(t => t.SuggestionVoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("SuggestionVote");
            this.Property(t => t.SuggestionVoteId).HasColumnName("SuggestionVoteID");
            this.Property(t => t.SuggestionId).HasColumnName("SuggestionID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.DateOfVote).HasColumnName("DateOfVote");
            this.Property(t => t.Vote).HasColumnName("Vote");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.SuggestionVotes)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.Suggestion)
                .WithMany(t => t.SuggestionVotes)
                .HasForeignKey(d => d.SuggestionId);

        }
    }
}
