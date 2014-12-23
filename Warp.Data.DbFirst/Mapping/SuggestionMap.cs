using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SuggestionMap : EntityTypeConfiguration<Suggestion>
    {
        public SuggestionMap()
        {
            // Primary Key
            HasKey(t => t.SuggestionId);

            // Properties
            Property(t => t.SuggestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("Suggestion");
            Property(t => t.SuggestionId).HasColumnName("SuggestionID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.SuggestionStatusId).HasColumnName("SuggestionStatusID");
            Property(t => t.AllowComments).HasColumnName("AllowComments");
            Property(t => t.DisplayComments).HasColumnName("DisplayComments");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.Suggestions)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.SuggestionStatus)
                .WithMany(t => t.Suggestions)
                .HasForeignKey(d => d.SuggestionStatusId);

        }
    }
}
