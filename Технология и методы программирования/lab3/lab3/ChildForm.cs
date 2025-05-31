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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
            toolStripComboBox1.ComboBox.SelectedIndexChanged += ViewingStyle_SelectedIndexChanged;
        }
        public void LoadPicture(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден:\n" + filePath);
                return;
            }

            pictureBox1.Load(filePath);

            // Установка режима отображения
            if (pictureBox1.Image.Width < pictureBox1.ClientRectangle.Width / 10)
                toolStripComboBox1.ComboBox.SelectedIndex = 2; // Center
            else
                toolStripComboBox1.ComboBox.SelectedIndex = 0; // Zoom

            // Обновление строки состояния
            if (statusStrip1.Items.Count > 0)
            {
                statusStrip1.Items[0].Text = $"Ширина: {pictureBox1.Image.Width}; Высота: {pictureBox1.Image.Height}";
            }
        }

        private void ViewingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.ComboBox.SelectedIndex)
            {
                case 0:
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break; // Масштабировать с сохранением пропорций
                case 1:
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break; // Растянуть
                case 2:
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break; // По центру
                case 3:
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break; // По размеру изображения
            }
        }
        private void panel1_Resize(object sender, EventArgs e)
        {
            this.pictureBox1.Size = this.panel1.ClientSize;
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
