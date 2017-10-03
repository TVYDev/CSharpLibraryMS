using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagementSystem.DomainModels;
using LibraryManagementSystem.Api;

namespace LibraryManagementSystem
{
    public sealed partial class frmAddBook : Form
    {
        private static frmAddBook _instance = null;

        private frmAddBook()
        {
            InitializeComponent();
        }

        public static frmAddBook GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmAddBook();
                }
                return _instance;
            }
        }

        private void frmClear()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtIsbn.Clear();
            txtYearEdition.Clear();
            numQty.Value = 1;
            picCover.Image = Properties.Resources.Cover;
            picCover.SizeMode = PictureBoxSizeMode.CenterImage;
            picCover.BorderStyle = BorderStyle.FixedSingle;
            btnBrowse.Visible = true;
            pnIdGenerated.Visible = false;
        }

        private bool frmValidateSucceed()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lblRequiredTitle.Visible = true;
                isSuccess = false;
            }
            else
            {
                lblRequiredTitle.Visible = false;
            }

            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                lblRequiredAuthor.Visible = true;
                isSuccess = false;
            }
            else
            {
                lblRequiredAuthor.Visible = false;
            }

            if (string.IsNullOrEmpty(txtYearEdition.Text))
            {
                lblRequiredEdition.Visible = true;
                isSuccess = false;
            }
            else
            {
                lblRequiredEdition.Visible = false;
            }
            return isSuccess;
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            pnIdGenerated.Visible = false;
            lblRequiredTitle.Visible = false;
            lblRequiredAuthor.Visible = false;
            lblRequiredEdition.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png";
            fileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(fileDialog.FileName))
            {
                picCover.Image = Image.FromFile(fileDialog.FileName);
                picCover.SizeMode = PictureBoxSizeMode.Zoom;
                picCover.BorderStyle = BorderStyle.None;
                btnBrowse.Visible = false;
            }
        }

        private void picCover_Click(object sender, EventArgs e)
        {
            btnBrowse_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmClear();
            btnSave.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!frmValidateSucceed()) return;

            int coverId;
            if (picCover.Image != null)
            {
                coverId = CoverApi.AddNewCover(LibraryModule.ImageToByteArray(picCover.Image));
            }
            else
            {
                coverId = -1;
            }

            var book = new Book
            {
                Title = txtTitle.Text,
                AuthorName = txtAuthor.Text,
                Isbn = txtIsbn.Text,
                YearEdition = Convert.ToInt32(txtYearEdition.Text),
                CoverId = coverId
            };

            int qty = (int)numQty.Value;

            var ids = BookApi.AddNewBook(book, qty);

            if (ids.Count > 0)
            {
                pnIdGenerated.Visible = true;
                btnSave.Enabled = false;
                btnReset.Enabled = false;
                btnNew.Enabled = true;
                txtTitle.Enabled = false;
                txtAuthor.Enabled = false;
                txtIsbn.Enabled = false;
                txtYearEdition.Enabled = false;
                numQty.Enabled = false;
                picCover.Enabled = false;
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnReset.Enabled = true;
            btnNew.Enabled = true;
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtIsbn.Enabled = true;
            txtYearEdition.Enabled = true;
            numQty.Enabled = true;
            picCover.Enabled = true;
            btnNew.Enabled = false;
            frmClear();
            txtTitle.Focus();
        }

        private void txtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void txtYearEdition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
