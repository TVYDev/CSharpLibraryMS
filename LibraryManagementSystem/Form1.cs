using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Api;
using LibraryManagementSystem.DomainModels;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var member = MemberApi.LoadMemberDetails(1);
            MessageBox.Show(member.Name);
        }

        private void LoadAllBook()
        {
            try
            {
                var books = BookApi.LoadAllBooks();
                string st = string.Empty;
                foreach (var book in books)
                {
                    st += book.Title + " " + book.AuthorName + " " + book.Isbn + " " + book.YearEdition + "\n";
                }
                MessageBox.Show(st);
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UndoDelete()
        {
            try
            {
                BookApi.UndoDeleteBook(1);
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Delete()
        {
            try
            {
                BookApi.DeleteBook(1);
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Update()
        {
            try
            {
                var book = new Book
                {
                    Id = 1,
                    Title = "title 2",
                    AuthorName = "author 2",
                    YearEdition = 2017,
                    Isbn = "abc123456787",
                };

                BookApi.UpdateBook(book);
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
            MessageBox.Show("SUCCESS");
        }

        private void LoadBook()
        {
            try
            {
                var book = BookApi.LoadBookDetails(1);
                MessageBox.Show(string.Format("{0}\t{1}\t{2}\t{3}", book.Title, book.AuthorName, book.Isbn, book.YearEdition));

            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Add()
        {
            var book = new Book
            {
                Title = "title 6",
                AuthorName = "author 6",
                YearEdition = 2014,
                Isbn = "abc123456784"
            };

            try
            {
                var ids = BookApi.AddNewBook(book,3);
                foreach (var id in ids)
                {
                    MessageBox.Show(id.ToString());
                }
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message);
            }
            

            
        }
    }
}
