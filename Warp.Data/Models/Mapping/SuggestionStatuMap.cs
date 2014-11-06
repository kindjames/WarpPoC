using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SuggestionStatuMap : EntityTypeConfiguration<SuggestionStatu>
    {
        public SuggestionStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.SuggestionStatusID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SuggestionStatus");
            this.Property(t => t.SuggestionStatusID).HasColumnName("SuggestionStatusID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
