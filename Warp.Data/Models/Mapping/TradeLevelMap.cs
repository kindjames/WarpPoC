using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TradeLevelMap : EntityTypeConfiguration<TradeLevel>
    {
        public TradeLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.TradeLevelID);

            // Properties
            this.Property(t => t.TradeLevelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("TradeLevel");
            this.Property(t => t.TradeLevelID).HasColumnName("TradeLevelID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
