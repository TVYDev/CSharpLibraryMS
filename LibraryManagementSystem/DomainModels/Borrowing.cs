using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.DomainModels
{
    public class Borrowing
    {
        public int Id { get; set; }

        [ForeignKey("MemberId")]
        public Member Member { get; set; }

        public int MemberId { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        public int BookId { get; set; }

        [ForeignKey("LibrarianId")]
        public Librarian Librarian { get; set; }

        public int LibrarianId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsReturned { get; set; }
    }
}