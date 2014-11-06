using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SuggestionMap : EntityTypeConfiguration<Suggestion>
    {
        public SuggestionMap()
        {
            // Primary Key
            this.HasKey(t => t.SuggestionID);

            // Properties
            this.Property(t => t.SuggestionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Suggestion");
            this.Property(t => t.SuggestionID).HasColumnName("SuggestionID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.SuggestionStatusID).HasColumnName("SuggestionStatusID");
            this.Property(t => t.AllowComments).HasColumnName("AllowComments");
            this.Property(t => t.DisplayComments).HasColumnName("DisplayComments");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.Suggestions)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.SuggestionStatu)
                .WithMany(t => t.Suggestions)
                .HasForeignKey(d => d.SuggestionStatusID);

        }
    }
}
