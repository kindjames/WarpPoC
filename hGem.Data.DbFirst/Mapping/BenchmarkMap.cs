using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BenchmarkMap : EntityTypeConfiguration<Benchmark>
    {
        public BenchmarkMap()
        {
            // Primary Key
            HasKey(t => t.BenchmarkId);

            // Properties
            Property(t => t.BenchmarkId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Benchmark");
            Property(t => t.BenchmarkId).HasColumnName("BenchmarkID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
