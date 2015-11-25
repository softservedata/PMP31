using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }
    }
}
