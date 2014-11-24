using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CriteriaConfigMap : EntityTypeConfiguration<CriteriaConfig>
    {
        public CriteriaConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.CriteriaConfigId);

            // Properties
            this.Property(t => t.CriteriaConfigId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SQL)
                .IsRequired()
                .HasMaxLength(450);

            // Table & Column Mappings
            this.ToTable("CriteriaConfig");
            this.Property(t => t.CriteriaConfigId).HasColumnName("CriteriaConfigID");
            this.Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            this.Property(t => t.CriteriaOptionId).HasColumnName("CriteriaOptionID");
            this.Property(t => t.CriteriaOperatorId).HasColumnName("CriteriaOperatorID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.SQL).HasColumnName("SQL");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CriteriaOperator)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaOperatorId);
            this.HasRequired(t => t.CriteriaOption)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaOptionId);
            this.HasRequired(t => t.CriteriaSet)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaSetId);

        }
    }
}
