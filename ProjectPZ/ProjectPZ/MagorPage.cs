using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPZ.DAL;

namespace ProjectPZ
{
    public partial class MagorPage : Form
    {
        public int arg;
        public MagorPage()
        {
            InitializeComponent();
        }
        public MagorPage(int arg_id)
        {
            InitializeComponent();
            arg = arg_id;
        }

        private void MagorPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            logAdminBtn.Enabled = false;
            if (arg == 4)
            {
                logManagCaterBtn.Enabled = true;
            }
            else
            {
                logManagCaterBtn.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logManagCaterBtn_Click(object sender, EventArgs e)
        {
            CategMagorForm categ = new CategMagorForm();
            categ.Show();
        }
    }
}
