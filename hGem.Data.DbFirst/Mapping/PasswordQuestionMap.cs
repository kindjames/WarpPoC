using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PasswordQuestionMap : EntityTypeConfiguration<PasswordQuestion>
    {
        public PasswordQuestionMap()
        {
            // Primary Key
            HasKey(t => t.PasswordQuestionId);

            // Properties
            Property(t => t.Question)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("PasswordQuestion", "Account");
            Property(t => t.PasswordQuestionId).HasColumnName("PasswordQuestionID");
            Property(t => t.Question).HasColumnName("Question");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
