using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIpictures
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public PictureBox PictureBox1()
        {
        
        return this.pictureBox1;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void LoadPicture()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(.jpg .tiff .gif .png .bmp)|*.jpg;.tiff; .gif; .png";
            dlg.FilterIndex = 1;      //default
            dlg.Multiselect = false;   //Gets or sets a value that indicates whether the OpenFileDialog allows users to select multiple files.
            //bool? CLickOk=dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //System.IO.Stream file = dlg.OpenFile();
                //using (System.IO.StreamReader fileR = new System.IO.StreamReader(file))

                pictureBox1.Load(dlg.FileName);
                Text = dlg.FileName;
                //file.Close();
            }
            Show();
        }

        public void LoadPicture(PictureBox p)
        {
            
                pictureBox1=p;
                
                //file.Close();
            
            //Show();
        }
    }
}
