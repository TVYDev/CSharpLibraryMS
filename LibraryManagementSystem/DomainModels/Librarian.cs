namespace LibraryManagementSystem.DomainModels
{
    public class Librarian
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public bool IsDeleted { get; set; }

        public byte[] Photo { get; set; }
    }
}