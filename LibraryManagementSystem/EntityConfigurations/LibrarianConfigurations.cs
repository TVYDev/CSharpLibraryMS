using System.Data.Entity.ModelConfiguration;
using LibraryManagementSystem.DomainModels;

namespace LibraryManagementSystem.EntityConfigurations
{
    class LibrarianConfigurations : EntityTypeConfiguration<Librarian>
    {
        public LibrarianConfigurations()
        {
            Property(l => l.Name)
                .HasMaxLength(255)
                .IsRequired();

            Property(l => l.Password)
                .HasMaxLength(255)
                .IsRequired();

            Property(l => l.Phone)
                .HasMaxLength(15)
                .IsRequired();

            Property(l => l.Address)
                .IsRequired();
        }
    }
}