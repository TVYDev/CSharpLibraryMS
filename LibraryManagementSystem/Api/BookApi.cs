using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagementSystem.DomainModels;

namespace LibraryManagementSystem.Api
{
    public static class BookApi
    {
        public static Book LoadBookDetails(int bookId)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.SingleOrDefault(b => b.Id == bookId);
                if(book == null)
                    throw new InvalidOperationException("Book not found.");

                return book;
            }
        }

        public static IEnumerable<Book> LoadAllBooks()
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.ToList();
                if(books.Count == 0)
                    throw new InvalidOperationException("No book found.");

                return books;
            }
        }

        public static List<int> AddNewBook(Book book, int qty)
        {
            using (var context = new LibraryContext())
            {
                var ids = new List<int>();
                book.IsBorrowed = false;
                book.IsDeleted = false;
                for (int i = 0; i < qty; i++)
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                    ids.Add(context.Books.OrderByDescending(b => b.Id).First().Id);
                }
                return ids;
            }
        }

        public static void UpdateBook(Book book)
        {
            using (var context = new LibraryContext())
            {
                var bookInDb = context.Books.SingleOrDefault(b => b.Id == book.Id);
                if(bookInDb == null)
                    throw new InvalidOperationException("Book not found.");

                bookInDb.Title = book.Title;
                bookInDb.AuthorName = book.AuthorName;
                bookInDb.Isbn = book.Isbn;
                bookInDb.YearEdition = book.YearEdition;

                context.SaveChanges();
            }
        }

        public static void DeleteBook(int bookId)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.Where(b => b.IsDeleted == false).SingleOrDefault(b => b.Id == bookId);
                if(book == null)
                    throw new InvalidOperationException("Book not found.");

                if (book.IsBorrowed)
                    throw new InvalidOperationException("Book is borrowed.");

                book.IsDeleted = true;
                context.SaveChanges();
            }
        }

        public static void UndoDeleteBook(int bookId)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.Where(b => b.IsDeleted).SingleOrDefault(b => b.Id == bookId);
                if (book == null)
                    throw new InvalidOperationException("Book not found.");

                book.IsDeleted = false;
                context.SaveChanges();
            }
        }
    }
}
