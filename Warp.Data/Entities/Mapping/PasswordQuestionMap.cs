using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PasswordQuestionMap : EntityTypeConfiguration<PasswordQuestion>
    {
        public PasswordQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.PasswordQuestionID);

            // Properties
            this.Property(t => t.Question)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PasswordQuestion", "Account");
            this.Property(t => t.PasswordQuestionID).HasColumnName("PasswordQuestionID");
            this.Property(t => t.Question).HasColumnName("Question");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
