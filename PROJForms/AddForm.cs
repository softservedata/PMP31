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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection(@"Data Source=MARICHKA-ПК\SQLEXPRESS;Initial Catalog=DeviceCategory;Integrated Security=True");
        int i;

        private void add_btn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO Category(id_category, c_name)values('" + new_id_txt.Text + "', '" + new_name_txt.Text + "')", con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            load_data();
            MessageBox.Show("added");
            
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
            new_id_txt.Text = "";
            new_name_txt.Text = "";
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            con1.Open();
            load_data();
        }
    }
}
