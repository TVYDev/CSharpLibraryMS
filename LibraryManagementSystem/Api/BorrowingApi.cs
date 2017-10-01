using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DomainModels;

namespace LibraryManagementSystem.Api
{
    public static class BorrowingApi
    {
        public static void BorrowBook (IEnumerable<int> bookIds, int memberId, int librarianId)
        {
            using (var context = new LibraryContext())
            {
                if (bookIds.Count() == 0)
                    throw new InvalidOperationException("No Books are tempted to be borrowed.");

                var borrowing = new Borrowing
                {
                    BorrowDate = DateTime.Today,
                    DueDate = DateTime.Today.AddDays(PredefinedRules.AllowedDaysToBorrow),
                    MemberId = memberId,
                    LibrarianId = librarianId,
                    IsReturned = false
                };

                foreach(var bookId in bookIds)
                {
                    borrowing.BookId = bookId;
                    context.Borrowings.Add(borrowing);
                    context.SaveChanges();
                }

                var member = context.Members.Single(m => m.Id == memberId);
                member.MaxBookLimit -= (byte)bookIds.Count();
                
                var books = context.Books.Where(b => bookIds.Contains(b.Id)).ToList();
                foreach(var book in books)
                {
                    book.IsBorrowed = true;
                }

                context.SaveChanges();
            }
        }

        public static void ReturnBook (IEnumerable<int> bookIds)
        {
            using (var context = new LibraryContext())
            {
                var borrowings = context.Borrowings.Where(b => b.IsReturned == false && bookIds.Contains(b.BookId)).ToList();
                if (borrowings.Count == 0)
                    throw new InvalidOperationException("No borrowed books found.");

                foreach (var borrowing in borrowings)
                {
                    borrowing.IsReturned = true;
                }

                var member = context.Members.Find(borrowings[0].MemberId);
                member.MaxBookLimit += (byte)borrowings.Count();

                var books = context.Books.Where(b => bookIds.Contains(b.Id)).ToList();
                foreach(var book in books)
                {
                    book.IsBorrowed = false;
                }

                context.SaveChanges();
            }
        }
    }
}
