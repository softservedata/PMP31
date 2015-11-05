using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TotalRecall
{
    public partial class Orders : Form
    {
        private List<OrderDTO> OrdersList;

        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        public void UpdateList()
        {
            orderDTODataGridView.DataSource = null;

            backgroundWorker1.RunWorkerAsync();
        }

        private void orderDTODataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = orderDTODataGridView.Rows[e.RowIndex];
            int orderID = (int)row.Cells["orderID"].Value;

            //MessageBox.Show(string.Format("You have selected order {0}", orderID));

            using (OrderDetails odForm = new OrderDetails(orderID))
            {
                var result = odForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    UpdateList();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Manager m = new Manager();
            OrdersList = m.GetOrders();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            orderDTOBindingSource.DataSource = OrdersList;
            orderDTODataGridView.DataSource = orderDTOBindingSource;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (OrderDetails odForm = new OrderDetails())
            {
                if (odForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateList();
                }
            }
        }
    }
}
