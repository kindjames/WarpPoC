using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PeriodMap : EntityTypeConfiguration<Period>
    {
        public PeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodId);

            // Properties
            this.Property(t => t.PeriodId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Period");
            this.Property(t => t.PeriodId).HasColumnName("PeriodID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateStart).HasColumnName("DateStart");
            this.Property(t => t.DateEnd).HasColumnName("DateEnd");
            this.Property(t => t.ExcludeFromAnalysis).HasColumnName("ExcludeFromAnalysis");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
