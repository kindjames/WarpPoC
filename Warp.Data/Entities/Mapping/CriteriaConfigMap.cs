using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class CriteriaConfigMap : EntityTypeConfiguration<CriteriaConfig>
    {
        public CriteriaConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.CriteriaConfigID);

            // Properties
            this.Property(t => t.CriteriaConfigID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SQL)
                .IsRequired()
                .HasMaxLength(450);

            // Table & Column Mappings
            this.ToTable("CriteriaConfig");
            this.Property(t => t.CriteriaConfigID).HasColumnName("CriteriaConfigID");
            this.Property(t => t.CriteriaSetID).HasColumnName("CriteriaSetID");
            this.Property(t => t.CriteriaOptionID).HasColumnName("CriteriaOptionID");
            this.Property(t => t.CriteriaOperatorID).HasColumnName("CriteriaOperatorID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.SQL).HasColumnName("SQL");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CriteriaOperator)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaOperatorID);
            this.HasRequired(t => t.CriteriaOption)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaOptionID);
            this.HasRequired(t => t.CriteriaSet)
                .WithMany(t => t.CriteriaConfigs)
                .HasForeignKey(d => d.CriteriaSetID);

        }
    }
}
