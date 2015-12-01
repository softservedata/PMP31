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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            login_txt.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            UsersDAL user = new UsersDAL();
            UserDTO dto1 = new UserDTO();
            dto1 = user.GetUserByLogin(login_txt.Text);
            UserDTO dto2 = new UserDTO();
            dto2 = user.GetUserByPassword(password_txt.Text);
            if ((dto1!=null)&&(dto2!=null))
            {
                if (dto1.id_user == dto2.id_user)
                {
                    int arg = dto1.id_role;
                    MagorPage m = new MagorPage(arg);
                    m.Show();
                }
                else
                    MessageBox.Show("Enter correct Login or Password! ");
            }
            else
                MessageBox.Show("Enter correct Login or Password! ");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
