using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJForms
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection(@"Data Source=MARICHKA-ПК\SQLEXPRESS;Initial Catalog=DeviceCategory;Integrated Security=True");
        int i;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_category, c_name FROM Category WHERE id_category LIKE '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "NAME")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_category, c_name FROM Category WHERE c_name LIKE '" + textBox1.Text + "%'", con1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if ((name_txt.Text != "") || (id_txt.Text != ""))
            {
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Category SET c_name='" + name_txt.Text + "'  WHERE id_category='" + id_txt.Text + "' ", con1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                load_data();
                clear_fun();
                MessageBox.Show("edited");
            }
            else
            {
                MessageBox.Show("select row for editing");
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            id_txt.Enabled = false;
            load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            id_txt.Text = row.Cells[0].Value.ToString();
            name_txt.Text = row.Cells[1].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if ((name_txt.Text != "") || (id_txt.Text != ""))
            {
                SqlDataAdapter da = new SqlDataAdapter("DELETE FROM Category WHERE c_name='" + name_txt.Text + "'", con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                load_data();
                clear_fun();
                MessageBox.Show("deleted");
            }
            else 
            {
                MessageBox.Show("select row for deleting");
            }

        }
        void load_data()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Category", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void clear_fun()
        {
            id_txt.Text = "";
            name_txt.Text = "";
        }
    }
}
