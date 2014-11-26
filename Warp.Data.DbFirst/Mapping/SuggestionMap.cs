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
            this.HasKey(t => t.SuggestionId);

            // Properties
            this.Property(t => t.SuggestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Suggestion");
            this.Property(t => t.SuggestionId).HasColumnName("SuggestionID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.SuggestionStatusId).HasColumnName("SuggestionStatusID");
            this.Property(t => t.AllowComments).HasColumnName("AllowComments");
            this.Property(t => t.DisplayComments).HasColumnName("DisplayComments");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.Suggestions)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.SuggestionStatus)
                .WithMany(t => t.Suggestions)
                .HasForeignKey(d => d.SuggestionStatusId);

        }
    }
}
