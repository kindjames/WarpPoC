using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SuggestionStatusMap : EntityTypeConfiguration<SuggestionStatus>
    {
        public SuggestionStatusMap()
        {
            // Primary Key
            HasKey(t => t.SuggestionStatusId);

            // Properties
            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("SuggestionStatus");
            Property(t => t.SuggestionStatusId).HasColumnName("SuggestionStatusID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
