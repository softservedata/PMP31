using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm activeChild = (ChildForm)this.ActiveMdiChild;
            activeChild.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm activeChild = (ChildForm)this.ActiveMdiChild;
            RichTextBox richTextBox = (RichTextBox)activeChild.ActiveControl;
            Clipboard.SetDataObject(richTextBox.SelectedText);
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm activeChild = (ChildForm)this.ActiveMdiChild;
            RichTextBox richTextBox = (RichTextBox)activeChild.ActiveControl;
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(DataFormats.Text))
            {
                richTextBox.SelectedText = data.GetData(DataFormats.Text).ToString();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
