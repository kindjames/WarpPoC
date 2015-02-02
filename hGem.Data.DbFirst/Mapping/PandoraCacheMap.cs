using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PandoraCacheMap : EntityTypeConfiguration<PandoraCache>
    {
        public PandoraCacheMap()
        {
            // Primary Key
            HasKey(t => t.PandoraCacheId);

            // Properties
            Property(t => t.Data)
                .IsRequired();

            // Table & Column Mappings
            ToTable("PandoraCache");
            Property(t => t.PandoraCacheId).HasColumnName("PandoraCacheID");
            Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            Property(t => t.Data).HasColumnName("Data");
            Property(t => t.Expiry).HasColumnName("Expiry");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
