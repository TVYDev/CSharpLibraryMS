using LibraryManagementSystem.Api;
using LibraryManagementSystem.DomainModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public sealed partial class frmRegisterLibrarian : Form
    {
        private static frmRegisterLibrarian _instance = null;

        private frmRegisterLibrarian()
        {
            InitializeComponent();
        }

        public static frmRegisterLibrarian GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmRegisterLibrarian();

                return _instance;
            }
        }

        private void frmClear()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            picLibrarian.Image = Properties.Resources.Cover;
            picLibrarian.Width = picLibrarian.Height = 100;
            picLibrarian.Location = new Point(92, 145);
            picLibrarian.SizeMode = PictureBoxSizeMode.CenterImage;
            LibraryModule.makePictureBoxRound(picLibrarian);
            btnBrowse.Visible = true;
            recRoundPic.Visible = true;
            pnIdGenerated.Visible = false;
        }

        private bool frmValidateSucceed()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblRequiredName.Visible = true;
                isSuccess = false;
            }
            else
            {
                lblRequiredName.Visible = false;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                lblRequiredPhone.Visible = true;
                isSuccess = false;
            }
            else
            {
                lblRequiredPhone.Visible = false;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                lblRequiredAddress.Visible = true;
                isSuccess = false;
            }
            else
            {
                lblRequiredAddress.Visible = false;
            }
            return isSuccess;
        }

        private void frmRegisterLibrarian_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            btnNew.Enabled = false;
            pnIdGenerated.Visible = false;
            lblRequiredName.Visible = false;
            lblRequiredPhone.Visible = false;
            lblRequiredAddress.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png";
            fileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(fileDialog.FileName))
            {
                picLibrarian.Image = Image.FromFile(fileDialog.FileName);
                picLibrarian.Width = picLibrarian.Height = 185;
                picLibrarian.Location = new Point(48, 119);
                picLibrarian.SizeMode = PictureBoxSizeMode.Zoom;
                LibraryModule.makePictureBoxRound(picLibrarian);
                btnBrowse.Visible = false;
                recRoundPic.Visible = false;
            }
        }

        private void picLibrarian_Click(object sender, EventArgs e)
        {
            btnBrowse_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!frmValidateSucceed()) return;

            var librarian = new Librarian
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                Photo = LibraryModule.ImageToByteArray(picLibrarian.Image)
            };

            var id = LibrarianApi.AddNewLibrarian(librarian);

            if(id != 0)
            {
                pnIdGenerated.Visible = true;
                btnSave.Enabled = false;
                btnReset.Enabled = false;
                btnNew.Enabled = true;
                txtName.Enabled = false;
                txtPhone.Enabled = false;
                txtAddress.Enabled = false;
                picLibrarian.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmClear();
            btnSave.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnReset.Enabled = true;
            btnNew.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            picLibrarian.Enabled = true;
            btnNew.Enabled = false;
            frmClear();
            txtName.Focus();
        }
    }
}
