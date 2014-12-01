using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ForumThreadMap : EntityTypeConfiguration<ForumThread>
    {
        public ForumThreadMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumThreadId);

            // Properties
            this.Property(t => t.ForumThreadId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ThreadText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ForumThread");
            this.Property(t => t.ForumThreadId).HasColumnName("ForumThreadID");
            this.Property(t => t.ForumCategoryId).HasColumnName("ForumCategoryID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ThreadText).HasColumnName("ThreadText");
            this.Property(t => t.Views).HasColumnName("Views");
            this.Property(t => t.Locked).HasColumnName("Locked");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumThreads)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.ForumCategory)
                .WithMany(t => t.ForumThreads)
                .HasForeignKey(d => d.ForumCategoryId);

        }
    }
}
