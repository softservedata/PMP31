using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderManagerDataSet.Delivers' table. You can move, or remove it, as needed.
            this.deliversTableAdapter.Fill(this.orderManagerDataSet.Delivers);
            // TODO: This line of code loads data into the 'orderManagerDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.orderManagerDataSet.Orders);

        }
    }
}
