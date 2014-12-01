using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MenuConfigClientMap : EntityTypeConfiguration<MenuConfigClient>
    {
        public MenuConfigClientMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigClientId);

            // Properties
            this.Property(t => t.MenuConfigClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfigClient");
            this.Property(t => t.MenuConfigClientId).HasColumnName("MenuConfigClientID");
            this.Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.MenuConfigClients)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigClients)
                .HasForeignKey(d => d.MenuConfigId);

        }
    }
}
