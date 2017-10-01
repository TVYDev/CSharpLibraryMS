using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DomainModels;
using DevOne.Security.Cryptography.BCrypt;

namespace LibraryManagementSystem.Api
{
    public static class LibrarianApi
    {
        public static Librarian LibrarianLogin (string name, string pwd)
        {
            using (var context = new LibraryContext())
            {
                var stringError = "Invalid name or password.";

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pwd))
                {
                    throw new InvalidOperationException(stringError);
                }

                var librarian = context.Librarians.SingleOrDefault(l => l.Name.Equals(name));
                if (librarian == null)
                    throw new InvalidOperationException(stringError);

                var loginSuccess = BCryptHelper.CheckPassword(pwd, librarian.Password);
                if (!loginSuccess)
                    throw new InvalidOperationException(stringError);

                return librarian;
            }
        }

        public static int AddNewLibrarian(Librarian librarian)
        {
            using (var context = new LibraryContext())
            {
                var nameIsExisting = context.Librarians.Any(l => l.Name == librarian.Name);
                if (nameIsExisting)
                    throw new InvalidOperationException("This name is already existed. Make your name more unique");

                librarian.IsDeleted = false;
                librarian.Password = BCryptHelper.HashPassword(librarian.Password, BCryptHelper.GenerateSalt());
                context.Librarians.Add(librarian);
                context.SaveChanges();
                return context.Librarians.OrderByDescending(l => l.Id).First().Id;
            }
        }

        public static void UpdateLibrarian (Librarian librarian)
        {
            using (var context = new LibraryContext())
            {
                var librarianInDb = context.Librarians.SingleOrDefault(l => l.Id == librarian.Id);
                if (librarianInDb == null)
                    throw new InvalidOperationException("Librarian not found.");

                librarianInDb.Name = librarian.Name;
                librarianInDb.Phone = librarian.Phone;
                librarianInDb.Address = librarian.Address;
                context.SaveChanges();
            }
        }

        public static void DeleteLibrarian (int librarianId)
        {
            using (var context = new LibraryContext())
            {
                var librarian = context.Librarians.Where(l => l.IsDeleted == false).SingleOrDefault(l => l.Id == librarianId);
                if (librarian == null)
                    throw new InvalidOperationException("Librarian not found.");

                librarian.IsDeleted = true;
                context.SaveChanges();
            }
        }

        public static void UndoDeleteLibrarian(int librarianId)
        {
            using (var context = new LibraryContext())
            {
                var librarian = context.Librarians.Where(l => l.IsDeleted).SingleOrDefault(l => l.Id == librarianId);
                if (librarian == null)
                    throw new InvalidOperationException("Librarian not found.");

                librarian.IsDeleted = false;
                context.SaveChanges();
            }
        }


        public static Librarian LoadLibrarianDetails (int librarianId)
        {
            using (var context = new LibraryContext())
            {
                var librarian = context.Librarians.SingleOrDefault(l => l.Id == librarianId);
                if (librarian == null)
                    throw new InvalidOperationException("Librarian not found.");

                return librarian;
            }
        }

        public static IEnumerable<Librarian> SearchLibrarian (string input, int numbersToSkip)
        {
            using (var context = new LibraryContext())
            {
                var convertedToInt = Convert.ToInt32(input);
                var librarians = new List<Librarian>();
                if (input.All(c => c >= '0' && c <= '9')){
                    librarians = context.Librarians.Where(l => l.Id == convertedToInt || l.Phone == input)
                                                   .OrderBy(l => l.Id)
                                                   .Skip(numbersToSkip)
                                                   .Take(PredefinedRules.ShownPerPage)
                                                   .ToList();
                }
                else
                {
                    librarians = context.Librarians.Where(l => l.Name.Contains(input.ToLower()) || l.Address.Contains(input.ToLower()))
                                                   .OrderBy(l => l.Id)
                                                   .Skip(numbersToSkip)
                                                   .Take(PredefinedRules.ShownPerPage)
                                                   .ToList();
                }

                if (librarians.Count == 0)
                    throw new InvalidOperationException("Librarian not found.");

                return librarians;
            }
        }
    }
}
