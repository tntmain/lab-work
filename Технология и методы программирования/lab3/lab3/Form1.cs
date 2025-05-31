using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                FolderName = FolderDialog.SelectedPath;
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
        private void MenuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MenuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuAboutAuthor_Click(object sender, EventArgs e)
        {
            AboutAuthor AA = new AboutAuthor();
            AA.ShowDialog();
        }

        private void MenuAboutProgram_Click(object sender, EventArgs e)
        {
            string Path = "Отчет_Буак.docx";
            if (System.IO.File.Exists(Path))
                Process.Start(Path);
            else
                MessageBox.Show("Файл Отчет_Буак.docx в папке с программой не найден",
                                "Ошибка открытия файла",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
        }

        private string FolderName = "";
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string fileName = listBox1.SelectedItem.ToString().Trim(); // убираем лишние пробелы
            string fullPath = Path.Combine(FolderName, fileName);      // безопасно соединяем путь

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("Файл не найден:\n" + fullPath);
                return;
            }

            ChildForm frm = new ChildForm();
            frm.MdiParent = this;
            frm.Width = (int)(this.Width * 0.6);
            frm.Height = (int)(this.Height * 0.6);
            frm.Text = "Изображение: " + fileName;
            frm.LoadPicture(fullPath);
            frm.FormClosed += (obj, args) => ClosingFrm(frm);
            frm.Show();
            CalculateWinCount();
        }

        /// <summary>
        /// Функция для обработки события закрытия дочерней формы
        /// </summary>
        /// <param name="F">Закрываемая форма</param>
        private void ClosingFrm(Form F)
        {
            F.Hide(); // Скрытие формы
            F.MdiParent = null; // Отключение от родительской формы
            CalculateWinCount(); // Вызов функции для расчета количества открытых дочерних окон
        }

        /// <summary>
        /// Пользовательская функция для расчета количества открытых дочерних окон
        /// </summary>
        private void CalculateWinCount()
        {
            int WinCount = this.MdiChildren.Count(); // Определение количества открытых дочерних окон
            this.StatusWindowsCount.Text = "Открыто окон: " + Convert.ToString(WinCount); // Вывод в текстовый элемент StatusWindowsCount
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
