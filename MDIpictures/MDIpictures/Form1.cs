using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MDIpictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            child.LoadPicture();
        }

        private void pictureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 active = (Form2)ActiveMdiChild;
            if (active != null)
            {
                active.LoadPicture();
            }

        }

        private void nameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            int a = 0;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
                if (MdiChildren[i] == ActiveMdiChild)
                    a = i;
            }
            textBox1.Visible = true;
            button1.Visible = true;

            textBox1.Text = "type a new name";
            Clipboard.SetData("int", a);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData("int"))
            {
                Form2 active = (Form2)MdiChildren[(int)Clipboard.GetData("int")];
                Clipboard.Clear();
                active.Text = textBox1.Text;
                active.Show();
            }
            for (int i = 0; i < MdiChildren.Length; i++)
                if (MdiChildren[i].Text == textBox1.Text)
                {
                    MdiChildren[i].Show();
                    break;
                }
            textBox1.Visible = false;
            button1.Visible = false;


        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 active = (Form2)ActiveMdiChild;
            if (active != null)
                active.Close();
        }

        private void closeAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
                MdiChildren[i].Close();
        }

        private void allToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
                MdiChildren[i].Show();
        }

        private void noneToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
                MdiChildren[i].Hide();
        }

        private void byNameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();

            }
            textBox1.Visible = true;
            button1.Visible = true;

            textBox1.Text = "type a new name";

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void noResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for (int i=0;i<MdiChildren.Length;i++)
               // MdiChildren[i].
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 active = (Form2)ActiveMdiChild;
            //Image p = (Image) active.PictureBox1();
            if (active != null)
            {
              
                Clipboard.SetImage(active.PictureBox1().Image);
                //Clipboard.SetText(active.PictureBox1().Image
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 n = (Form2)ActiveMdiChild;
            n.PictureBox1().Image = Clipboard.GetImage();
        }

        

        
    }
}
