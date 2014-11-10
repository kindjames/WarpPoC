using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BriefItemMap : EntityTypeConfiguration<BriefItem>
    {
        public BriefItemMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefItemID);

            // Properties
            this.Property(t => t.BriefItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BriefItem");
            this.Property(t => t.BriefItemID).HasColumnName("BriefItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
