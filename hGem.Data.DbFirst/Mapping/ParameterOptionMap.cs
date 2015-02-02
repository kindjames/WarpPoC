using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ParameterOptionMap : EntityTypeConfiguration<ParameterOption>
    {
        public ParameterOptionMap()
        {
            // Primary Key
            HasKey(t => t.ParameterOptionId);

            // Properties
            // Table & Column Mappings
            ToTable("ParameterOption", "Subscriptions");
            Property(t => t.ParameterOptionId).HasColumnName("ParameterOptionId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
