using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Area", "Client");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AreaStatusId).HasColumnName("AreaStatusID");
            this.Property(t => t.RegionId).HasColumnName("RegionID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.AreaStatus)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.AreaStatusId);
            this.HasRequired(t => t.Region)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.RegionId);

        }
    }
}
