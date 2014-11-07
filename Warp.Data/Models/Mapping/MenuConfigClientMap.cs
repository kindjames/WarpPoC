using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MenuConfigClientMap : EntityTypeConfiguration<MenuConfigClient>
    {
        public MenuConfigClientMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigClientID);

            // Properties
            this.Property(t => t.MenuConfigClientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfigClient");
            this.Property(t => t.MenuConfigClientID).HasColumnName("MenuConfigClientID");
            this.Property(t => t.MenuConfigID).HasColumnName("MenuConfigID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.MenuConfigClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigClients)
                .HasForeignKey(d => d.MenuConfigID);

        }
    }
}
