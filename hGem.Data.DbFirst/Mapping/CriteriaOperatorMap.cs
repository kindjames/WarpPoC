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
            HasKey(t => t.CriteriaOperatorId);

            // Properties
            Property(t => t.CriteriaOperatorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.SQLOperatorStart)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.SQLOperatorEnd)
                .HasMaxLength(30);

            // Table & Column Mappings
            ToTable("CriteriaOperators");
            Property(t => t.CriteriaOperatorId).HasColumnName("CriteriaOperatorID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.SQLOperatorStart).HasColumnName("SQLOperatorStart");
            Property(t => t.SQLOperatorEnd).HasColumnName("SQLOperatorEnd");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
