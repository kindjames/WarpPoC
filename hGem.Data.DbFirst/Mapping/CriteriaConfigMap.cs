using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CriteriaConfigMap : EntityTypeConfiguration<CriteriaConfig>
    {
        public CriteriaConfigMap()
        {
            // Primary Key
            HasKey(t => t.CriteriaConfigId);

            // Properties
            Property(t => t.CriteriaConfigId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.SQL)
                .IsRequired()
                .HasMaxLength(450);

            // Table & Column Mappings
            ToTable("CriteriaConfig");
            Property(t => t.CriteriaConfigId).HasColumnName("CriteriaConfigID");
            Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            Property(t => t.CriteriaOptionId).HasColumnName("CriteriaOptionID");
            Property(t => t.CriteriaOperatorId).HasColumnName("CriteriaOperatorID");
            Property(t => t.Value).HasColumnName("Value");
            Property(t => t.SQL).HasColumnName("SQL");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.CriteriaOperator)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaOperatorId);
            HasRequired(t => t.CriteriaOption)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaOptionId);
            HasRequired(t => t.CriteriaSet)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaSetId);

        }
    }
}
