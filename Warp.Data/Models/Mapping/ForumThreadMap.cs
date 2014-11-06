using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ForumThreadMap : EntityTypeConfiguration<ForumThread>
    {
        public ForumThreadMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumThreadID);

            // Properties
            this.Property(t => t.ForumThreadID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ThreadText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ForumThread");
            this.Property(t => t.ForumThreadID).HasColumnName("ForumThreadID");
            this.Property(t => t.ForumCategoryID).HasColumnName("ForumCategoryID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ThreadText).HasColumnName("ThreadText");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.Views).HasColumnName("Views");
            this.Property(t => t.Locked).HasColumnName("Locked");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumThreads)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.ForumCategory)
                .WithMany(t => t.ForumThreads)
                .HasForeignKey(d => d.ForumCategoryID);

        }
    }
}
