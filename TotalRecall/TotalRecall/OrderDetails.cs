using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalRecall
{
    public partial class OrderDetails : Form
    {
        private int _orderID;
        private Manager _manager;

        public OrderDetails(int orderID = 0)
        {
            InitializeComponent();

            _manager = new Manager();

            employeeDTOBindingSource.DataSource = _manager.GetEmployees();
            customerDTOBindingSource.DataSource = _manager.GetCustomers();

            if (orderID != 0)
            {
                _orderID = orderID;
               
                orderDTOBindingSource.DataSource = _manager.GetOrderByID(orderID);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_orderID != 0)
            {
                var updatedOrder = orderDTOBindingSource.DataSource as OrderDTO;

                _manager.UpdateOrder(updatedOrder);
            }
            else
            {
                _manager.AddOrder();
            }
            this.Close();
        }

        private void customerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_orderID != 0 && customerIDComboBox.SelectedValue != null)
            {
                string selectedCustomerID = customerIDComboBox.SelectedValue.ToString();
                (orderDTOBindingSource.DataSource as OrderDTO).CustomerID = selectedCustomerID;
            }
        }

        private void orderDTOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void orderDTOBindingSource_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void orderDTOBindingSource_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void orderDTOBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
           
        }

        private void orderDTOBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void orderDTOBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }
    }
}
