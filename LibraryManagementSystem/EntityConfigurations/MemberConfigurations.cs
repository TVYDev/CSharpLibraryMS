using System.Data.Entity.ModelConfiguration;
using LibraryManagementSystem.DomainModels;

namespace LibraryManagementSystem.EntityConfigurations
{
    class MemberConfigurations : EntityTypeConfiguration<Member>
    {
        public MemberConfigurations()
        {
            Property(m => m.Name)
                .HasMaxLength(255)
                .IsRequired();

            Property(m => m.Phone)
                .HasMaxLength(15)
                .IsRequired();

            Property(m => m.Address)
                .IsRequired();
        }
    }
}