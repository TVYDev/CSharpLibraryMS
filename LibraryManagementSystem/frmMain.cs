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
    public partial class frmMain : Form
    {
        public frmMain()
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

            pnDisplay.BackColor = this.BackColor;
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
            if (!pnDisplay.Controls.Contains(frmAddBook.GetInstance))
            {
                pnDisplay.Controls.Clear();
                var formAddBook = frmAddBook.GetInstance;
                formAddBook.TopLevel = false;
                formAddBook.BackColor = this.BackColor;
                pnDisplay.Controls.Add(formAddBook);
                formAddBook.Show();
            }

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
