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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstn_txt.Focus();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersDAL user = new UsersDAL();
            UserDTO dto = new UserDTO();
            //----------------
            UserDTO dto1 = new UserDTO();
            dto1 = user.GetUserByLogin(login_txt.Text);
            //--------------
            if (checkIsEmptyField())
            {
                MessageBox.Show("Fill in the blank fields!");
            }
            else if (dto1.login == null)
            {
                dto.first_name = firstn_txt.Text;
                dto.last_name = lastn_txt.Text;
                dto.email = email_txt.Text;
                dto.phone_number = number_txt.Text;
                dto.login = login_txt.Text;
                dto.password = password_txt.Text;
                dto.id_role = 1;
                user.insertUser(dto);
                MagorPage m = new MagorPage();
                m.Show();
                clear_fun();
            }
            else 
            {
                MessageBox.Show("Input another login!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        bool checkIsEmptyField()
        {
            if ((firstn_txt.Text == "") || (lastn_txt.Text == "") || (email_txt.Text == "") ||
                (number_txt.Text == "") || (login_txt.Text == "") || (password_txt.Text == ""))
            {
                return true;
            }
            return false;
        }
        void clear_fun()
        {
            firstn_txt.Text = "";
            lastn_txt.Text = "";
            email_txt.Text = "";
            number_txt.Text = "";
            login_txt.Text = "";
            password_txt.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
