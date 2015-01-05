using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            HasKey(t => t.AreaId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Area", "Client");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.AreaStatusId).HasColumnName("AreaStatusID");
            Property(t => t.RegionId).HasColumnName("RegionID");
            Property(t => t.Code).HasColumnName("Code");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.AreaStatus)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.AreaStatusId);
            HasRequired(t => t.Region)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.RegionId);

        }
    }
}
