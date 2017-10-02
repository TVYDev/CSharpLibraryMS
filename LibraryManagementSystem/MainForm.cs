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
using DevOne.Security.Cryptography.BCrypt;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StylingForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void StylingForm()
        {
            FormBorderStyle = FormBorderStyle.None;

            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnSelect.Height = btnSearch.Height;
            pnSelect.Top = btnSearch.Top;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            pnSelect.Height = btnBorrow.Height;
            pnSelect.Top = btnBorrow.Top;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnSelect.Height = btnReturn.Height;
            pnSelect.Top = btnReturn.Top;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            pnSelect.Height = btnAddBook.Height;
            pnSelect.Top = btnAddBook.Top;
        }

        private void btnRegisterMember_Click(object sender, EventArgs e)
        {
            pnSelect.Height = btnRegisterMember.Height;
            pnSelect.Top = btnRegisterMember.Top;
        }

        private void btnRegisterLibrarian_Click(object sender, EventArgs e)
        {
            pnSelect.Height = btnRegisterLibrarian.Height;
            pnSelect.Top = btnRegisterLibrarian.Top;
        }
    }
}
