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
            HasKey(t => t.CriteriaSetId);

            // Properties
            Property(t => t.CriteriaSetId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("CriteriaSet");
            Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
