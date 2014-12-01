using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PasswordQuestionMap : EntityTypeConfiguration<PasswordQuestion>
    {
        public PasswordQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.PasswordQuestionId);

            // Properties
            this.Property(t => t.Question)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PasswordQuestion", "Account");
            this.Property(t => t.PasswordQuestionId).HasColumnName("PasswordQuestionID");
            this.Property(t => t.Question).HasColumnName("Question");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
