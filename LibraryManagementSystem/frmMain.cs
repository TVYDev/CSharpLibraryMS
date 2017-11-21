using System;
using System.Windows.Forms;

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

            LibraryModule.makePictureBoxRound(picAccount);
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
            if (!pnDisplay.Controls.Contains(frmRegisterLibrarian.GetInstance))
            {
                pnDisplay.Controls.Clear();
                var formRegisterLibrarian = frmRegisterLibrarian.GetInstance;
                formRegisterLibrarian.TopLevel = false;
                formRegisterLibrarian.BackColor = this.BackColor;
                pnDisplay.Controls.Add(formRegisterLibrarian);
                formRegisterLibrarian.Show();
            }

            pnSelect.Height = btnRegisterLibrarian.Height;
            pnSelect.Top = btnRegisterLibrarian.Top;
        }
    }
}
