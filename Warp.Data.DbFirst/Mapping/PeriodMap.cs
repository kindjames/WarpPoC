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
            HasKey(t => t.PeriodId);

            // Properties
            Property(t => t.PeriodId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Period");
            Property(t => t.PeriodId).HasColumnName("PeriodID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateStart).HasColumnName("DateStart");
            Property(t => t.DateEnd).HasColumnName("DateEnd");
            Property(t => t.ExcludeFromAnalysis).HasColumnName("ExcludeFromAnalysis");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
