using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MenuOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderDialog = new FolderBrowserDialog();
            FolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (FolderDialog.ShowDialog(this) == DialogResult.OK)
            {
                var FolderName = FolderDialog.SelectedPath;
                this.statusStrip1.Items[0].Text = FolderName;
                listBox1.Items.Clear();

                foreach (string f in Directory.GetFiles(FolderName, "*.bmp", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(f));
                }

                foreach (string f in Directory.GetFiles(FolderName, "*.jpg", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(f));
                }

                foreach (string f in Directory.GetFiles(FolderName, "*.png", SearchOption.TopDirectoryOnly))
                {
                    this.listBox1.Items.Add(System.IO.Path.GetFileName(f));
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mENUITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
