using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPZ
{
    public partial class CategMagorForm : Form
    {
        public CategMagorForm()
        {
            InitializeComponent();
        }

        private void CategMagorForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            FormList list = new FormList();
            list.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            FormDelete delete = new FormDelete();
            delete.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            FormEdit edit = new FormEdit();
            edit.Show();
        }
    }
}
