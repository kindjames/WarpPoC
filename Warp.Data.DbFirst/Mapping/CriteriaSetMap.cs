using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CriteriaSetMap : EntityTypeConfiguration<CriteriaSet>
    {
        public CriteriaSetMap()
        {
            // Primary Key
            this.HasKey(t => t.CriteriaSetId);

            // Properties
            this.Property(t => t.CriteriaSetId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CriteriaSet");
            this.Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
