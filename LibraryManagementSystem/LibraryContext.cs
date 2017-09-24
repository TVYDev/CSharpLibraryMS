using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.EntityConfigurations;

namespace LibraryManagementSystem
{
    class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookConfigurations());
            modelBuilder.Configurations.Add(new LibrarianConfigurations());
            modelBuilder.Configurations.Add(new MemberConfigurations());

            base.OnModelCreating(modelBuilder);
        }
    }
}
