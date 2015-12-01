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
    public partial class SingInForm1 : Form
    {
        public SingInForm1()
        {
            InitializeComponent();
        }

        private void SingInForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void singin_btn_Click(object sender, EventArgs e)
        {
            UsersDAL user = new UsersDAL();
            UserDTO dto = new UserDTO();
            dto = user.GetUserByLoginPassword(dto.login, dto.password);
            if (dto.id_user != 0)
            {
                MagorPage m = new MagorPage();
                m.Show();
            }
        }
    }
}
