using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefMap : EntityTypeConfiguration<Brief>
    {
        public BriefMap()
        {
            // Primary Key
            HasKey(t => t.BriefId);

            // Properties
            Property(t => t.BriefId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Brief");
            Property(t => t.BriefId).HasColumnName("BriefID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
