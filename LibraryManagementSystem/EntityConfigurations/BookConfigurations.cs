using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.EntityConfigurations
{
    class BookConfigurations : EntityTypeConfiguration<Book>
    {
        public BookConfigurations()
        {
            Property(b => b.Title)
                .HasMaxLength(255)
                .IsRequired();

            Property(b => b.AuthorName)
                .HasMaxLength(255)
                .IsRequired();

            
        }
    }
}
