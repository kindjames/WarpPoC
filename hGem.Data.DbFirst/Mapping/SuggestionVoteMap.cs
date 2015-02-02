using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SuggestionVoteMap : EntityTypeConfiguration<SuggestionVote>
    {
        public SuggestionVoteMap()
        {
            // Primary Key
            HasKey(t => t.SuggestionVoteId);

            // Properties
            Property(t => t.SuggestionVoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("SuggestionVote");
            Property(t => t.SuggestionVoteId).HasColumnName("SuggestionVoteID");
            Property(t => t.SuggestionId).HasColumnName("SuggestionID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.DateOfVote).HasColumnName("DateOfVote");
            Property(t => t.Vote).HasColumnName("Vote");
            Property(t => t.Comment).HasColumnName("Comment");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.SuggestionVotes)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.Suggestion)
                .WithMany(t => t.SuggestionVotes)
                .HasForeignKey(d => d.SuggestionId);

        }
    }
}
