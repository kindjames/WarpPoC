using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SuggestionStatusMap : EntityTypeConfiguration<SuggestionStatus>
    {
        public SuggestionStatusMap()
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
