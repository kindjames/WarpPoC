using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonCallBackRequestMap : EntityTypeConfiguration<PersonCallBackRequest>
    {
        public PersonCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonCallBackRequestID);

            // Properties
            this.Property(t => t.PersonCallBackRequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonCallBackRequest");
            this.Property(t => t.PersonCallBackRequestID).HasColumnName("PersonCallBackRequestID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.CallBackRequestID).HasColumnName("CallBackRequestID");

            // Relationships
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.PersonCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestID);

        }
    }
}
