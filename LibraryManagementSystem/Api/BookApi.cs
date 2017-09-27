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

        public static IEnumerable<Book> SearchBook(string input, int numbersToSkip)
        {
            using (var context = new LibraryContext())
            {
                var books = new List<Book>();
                if (input.All(c => c >= '0' && c <= '9'))
                {
                    var convertedToInt = Convert.ToInt32(input);
                    books = context.Books.Where(b => b.Id == convertedToInt ||
                                                         b.YearEdition == convertedToInt ||
                                                         b.Isbn == input)
                                                         .OrderBy(b => b.Id)
                                                         .Skip(numbersToSkip)
                                                         .Take(PredefinedRules.ShownPerPage)
                                                         .ToList();
                }
                else
                {
                    books = context.Books.Where(b => b.Title.ToLower().Contains(input.ToLower()) ||
                                                     b.AuthorName.ToLower().Contains(input.ToLower()))
                                                     .OrderBy(b => b.Id)
                                                     .Skip(numbersToSkip)
                                                     .Take(PredefinedRules.ShownPerPage)
                                                     .ToList();
                }

                if (books.Count == 0)
                    throw new InvalidOperationException("Book not found");
                return books;
            }
        }

        public static Book SearchBookById (int bookId)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.SingleOrDefault(b => b.Id == bookId);
                if (book == null)
                    throw new InvalidOperationException("Book not found.");

                return book;
            }
        }

        public static IEnumerable<Book> SearchBookByYearEdition(int yearEdition, int numbersToSkip)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.Where(b => b.YearEdition == yearEdition)
                                         .OrderBy(b => b.Id)
                                         .Skip(numbersToSkip)
                                         .Take(PredefinedRules.ShownPerPage)
                                         .ToList();
                if (books.Count == 0)
                    throw new InvalidOperationException("Book not found.");

                return books;
            }
        }

        public static Book SearchBookByIsbn(string isbn)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.SingleOrDefault(b => b.Isbn == isbn);
                if (book == null)
                    throw new InvalidOperationException("Book not found.");

                return book;
            }
        }

        public static IEnumerable<Book> SearchBookByTitle (string title, int numbersToSkip)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.Where(b => b.Title.Contains(title))
                                         .OrderBy(b => b.Id)
                                         .Skip(numbersToSkip)
                                         .Take(PredefinedRules.ShownPerPage)
                                         .ToList();
                if (books.Count == 0)
                    throw new InvalidOperationException("Book not found");

                return books;
            }
        }

        public static IEnumerable<Book> SearchBookByAuthorName(string authorName, int numbersToSkip)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.Where(b => b.AuthorName.Contains(authorName))
                                         .OrderBy(b => b.Id)
                                         .Skip(numbersToSkip)
                                         .Take(PredefinedRules.ShownPerPage)
                                         .ToList();
                if (books.Count == 0)
                    throw new InvalidOperationException("Book not found");

                return books;
            }
        }

        public static List<int> AddNewBook(Book book, int qty)
        {
            using (var context = new LibraryContext())
            {
                // set groupId by getting the last book id and add up 1
                int groupId;
                var lastBook = context.Books.OrderByDescending(b => b.Id).FirstOrDefault();
                if (lastBook == null)
                    groupId = 1;
                else
                    groupId = lastBook.Id + 1;

                // List to store all newly added books ids
                var ids = new List<int>();

                book.IsBorrowed = false;
                book.IsDeleted = false;
                book.GroupId = groupId;
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

                var groupId = bookInDb.GroupId;
                var booksInDb = context.Books.Where(b => b.GroupId == groupId).ToList();

                foreach(var b in booksInDb)
                {
                    b.Title = book.Title;
                    b.AuthorName = book.AuthorName;
                    b.Isbn = book.Isbn;
                    b.YearEdition = book.YearEdition;
                }

                context.SaveChanges();
            }
        }

        public static void DeleteBook(IEnumerable<int> ids)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.Where(b => b.IsDeleted == false && ids.Contains(b.Id)).ToList();
                if(books.Count == 0)
                    throw new InvalidOperationException("Books not found.");

                foreach(var book in books)
                {
                    book.IsDeleted = true;
                }

                context.SaveChanges();
            }
        }

        public static void UndoDeleteBook(IEnumerable<int> ids)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.Where(b => b.IsDeleted && ids.Contains(b.Id)).ToList();
                if (books.Count == 0)
                    throw new InvalidOperationException("Book not found.");

                foreach (var book in books)
                {
                    book.IsDeleted = false;
                }
                context.SaveChanges();
            }
        }
    }
}
