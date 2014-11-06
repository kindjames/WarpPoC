using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class StaffMemberMap : EntityTypeConfiguration<StaffMember>
    {
        public StaffMemberMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffMemberID);

            // Properties
            this.Property(t => t.StaffMemberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Notes)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("StaffMember");
            this.Property(t => t.StaffMemberID).HasColumnName("StaffMemberID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.StaffAgeID).HasColumnName("StaffAgeID");
            this.Property(t => t.StaffHeightID).HasColumnName("StaffHeightID");
            this.Property(t => t.StaffHairColourID).HasColumnName("StaffHairColourID");
            this.Property(t => t.StaffHairLengthID).HasColumnName("StaffHairLengthID");
            this.Property(t => t.StaffHairStyleID).HasColumnName("StaffHairStyleID");
            this.Property(t => t.GenderID).HasColumnName("GenderID");
            this.Property(t => t.CheckedByAdminID).HasColumnName("CheckedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Approved).HasColumnName("Approved");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");

            // Relationships
            this.HasRequired(t => t.Gender)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.GenderID);
            this.HasRequired(t => t.StaffAge)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffAgeID);
            this.HasRequired(t => t.StaffHairColour)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairColourID);
            this.HasRequired(t => t.StaffHairLength)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairLengthID);
            this.HasRequired(t => t.StaffHairStyle)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairStyleID);
            this.HasRequired(t => t.StaffHeight)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHeightID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
