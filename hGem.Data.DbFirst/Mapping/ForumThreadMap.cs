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
            HasKey(t => t.ForumThreadId);

            // Properties
            Property(t => t.ForumThreadId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.ThreadText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("ForumThread");
            Property(t => t.ForumThreadId).HasColumnName("ForumThreadID");
            Property(t => t.ForumCategoryId).HasColumnName("ForumCategoryID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.ThreadText).HasColumnName("ThreadText");
            Property(t => t.Views).HasColumnName("Views");
            Property(t => t.Locked).HasColumnName("Locked");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumThreads)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.ForumCategory)
                .WithMany(t => t.ForumThreads)
                .HasForeignKey(d => d.ForumCategoryId);

        }
    }
}
