using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CriteriaOperatorMap : EntityTypeConfiguration<CriteriaOperator>
    {
        public CriteriaOperatorMap()
        {
            // Primary Key
            this.HasKey(t => t.CriteriaOperatorId);

            // Properties
            this.Property(t => t.CriteriaOperatorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SQLOperatorStart)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SQLOperatorEnd)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CriteriaOperators");
            this.Property(t => t.CriteriaOperatorId).HasColumnName("CriteriaOperatorID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SQLOperatorStart).HasColumnName("SQLOperatorStart");
            this.Property(t => t.SQLOperatorEnd).HasColumnName("SQLOperatorEnd");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
