using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DomainModels
{
    public class BookCover
    {
        public int Id { get; set; }

        public byte[] Cover { get; set; }

        public Book Book { get; set; }
    }
}
