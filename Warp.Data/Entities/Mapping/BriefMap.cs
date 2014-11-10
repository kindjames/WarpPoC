using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BriefMap : EntityTypeConfiguration<Brief>
    {
        public BriefMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefID);

            // Properties
            this.Property(t => t.BriefID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Brief");
            this.Property(t => t.BriefID).HasColumnName("BriefID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
