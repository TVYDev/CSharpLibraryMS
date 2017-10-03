using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if(_instance == null)
                {
                    _instance = new frmAddBook();
                }
                return _instance;
            }
        }
    }
}
