using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BenchmarkMap : EntityTypeConfiguration<Benchmark>
    {
        public BenchmarkMap()
        {
            // Primary Key
            this.HasKey(t => t.BenchmarkID);

            // Properties
            this.Property(t => t.BenchmarkID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Benchmark");
            this.Property(t => t.BenchmarkID).HasColumnName("BenchmarkID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
