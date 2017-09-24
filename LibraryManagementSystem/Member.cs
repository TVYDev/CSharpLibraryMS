using System;

namespace LibraryManagementSystem
{
    public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime DateOfMembership { get; set; }

        public byte MaxBookLimit { get; set; }

        public bool IsDeleted { get; set; }
    }
}