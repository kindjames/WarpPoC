using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SuggestionStatuMap : EntityTypeConfiguration<SuggestionStatu>
    {
        public SuggestionStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.SuggestionStatusId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SuggestionStatus");
            this.Property(t => t.SuggestionStatusId).HasColumnName("SuggestionStatusID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
