using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem
{
    public class Librarian
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}