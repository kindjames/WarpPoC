using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ParameterOptionMap : EntityTypeConfiguration<ParameterOption>
    {
        public ParameterOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.ParameterOptionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ParameterOption", "Subscriptions");
            this.Property(t => t.ParameterOptionId).HasColumnName("ParameterOptionId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
