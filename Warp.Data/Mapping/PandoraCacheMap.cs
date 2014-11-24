using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PandoraCacheMap : EntityTypeConfiguration<PandoraCache>
    {
        public PandoraCacheMap()
        {
            // Primary Key
            this.HasKey(t => t.PandoraCacheId);

            // Properties
            this.Property(t => t.Data)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("PandoraCache");
            this.Property(t => t.PandoraCacheId).HasColumnName("PandoraCacheID");
            this.Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Expiry).HasColumnName("Expiry");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
