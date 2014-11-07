using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CriteriaSetMap : EntityTypeConfiguration<CriteriaSet>
    {
        public CriteriaSetMap()
        {
            // Primary Key
            this.HasKey(t => t.CriteriaSetID);

            // Properties
            this.Property(t => t.CriteriaSetID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CriteriaSet");
            this.Property(t => t.CriteriaSetID).HasColumnName("CriteriaSetID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
