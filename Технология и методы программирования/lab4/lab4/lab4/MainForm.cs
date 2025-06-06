using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace lab4
{
    public partial class MainForm : Form
    {
        // Переменные для сохранения исходной позиции перемещаемого элемента
        private int gCol, gRow, lItem;
        private string SourceName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Инициализация переменных
            gCol = -1;
            gRow = -1;
            lItem = -1;
            SourceName = "";

            // Настройка DataGridView
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowDrop = true;

            // Настройка ListBox
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            listBox1.Font = new Font("Microsoft Sans Serif", 16);
            listBox2.Font = new Font("Microsoft Sans Serif", 16);

            // Заполнение таблицы случайными числами
            Random rnd = new Random();
            for (int r = 0; r < 5; r++)
                for (int c = 0; c < 5; c++)
                    dataGridView1.Rows[r].Cells[c].Value = rnd.Next(100);

            // Вызов функции масштабирования
            this.OnResize(null);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Положение и размеры listBox1
            listBox1.Top = 25;
            listBox1.Left = 5;
            listBox1.Width = (int)(this.ClientSize.Width * 0.25) - listBox1.Left;
            listBox1.Height = this.ClientSize.Height - listBox1.Top - 40; // Уменьшено для кнопки

            // Полسورلوجة Положение и размеры dataGridView1
            dataGridView1.Top = listBox1.Top;
            dataGridView1.Left = listBox1.Left * 2 + listBox1.Width;
            dataGridView1.Width = (int)(this.ClientSize.Width * 0.5) - listBox1.Left * 2;
            dataGridView1.Height = listBox1.Height;

            // Положение и размеры listBox2
            listBox2.Top = listBox1.Top;
            listBox2.Left = dataGridView1.Left + dataGridView1.Width + listBox1.Left;
            listBox2.Width = listBox1.Width;
            listBox2.Height = listBox1.Height;

            // Положение и размеры button1
            button1.Top = listBox1.Top + listBox1.Height + 5;
            button1.Left = dataGridView1.Left;
            button1.Width = dataGridView1.Width;
            button1.Height = 30; // Фиксированная высота кнопки

            // Положение label1
            label1.Top = 3;
            label1.Left = listBox1.Left + listBox1.Width / 2 - label1.Width / 2;

            // Положение label2
            label2.Top = label1.Top;
            label2.Left = dataGridView1.Left + dataGridView1.Width / 2 - label2.Width / 2;

            // Положение label3
            label3.Top = label1.Top;
            label3.Left = listBox2.Left + listBox2.Width / 2 - label3.Width / 2;

            // Настройка размеров столбцов и строк таблицы
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.Width = (dataGridView1.Width + 2) / 5;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Height = (dataGridView1.Height + 2) / 5;
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridView.HitTestInfo cellPosition = dataGridView1.HitTest(e.X, e.Y);
                if (cellPosition.RowIndex >= 0 && cellPosition.ColumnIndex >= 0)
                {
                    SourceName = (sender as DataGridView).Name;
                    gCol = cellPosition.ColumnIndex;
                    gRow = cellPosition.RowIndex;
                    lItem = -1;
                    string text = dataGridView1.Rows[cellPosition.RowIndex].Cells[cellPosition.ColumnIndex].Value.ToString();
                    if (text != "")
                        dataGridView1.DoDragDrop(text, DragDropEffects.Move);
                }
            }
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            if ((sender as Control).Name == SourceName)
                return;

            string value = e.Data.GetData(DataFormats.Text).ToString();
            Point cursorPosition = dataGridView1.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo cellPosition = dataGridView1.HitTest(cursorPosition.X, cursorPosition.Y);

            if (cellPosition.ColumnIndex != -1 && cellPosition.RowIndex != -1)
            {
                dataGridView1[cellPosition.ColumnIndex, cellPosition.RowIndex].Value = value;
                if (lItem >= 0)
                    ((this.Controls[SourceName]) as ListBox).Items.RemoveAt(lItem);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int itemPosition = (sender as ListBox).SelectedIndex;
                if (itemPosition != -1)
                {
                    SourceName = (sender as ListBox).Name;
                    gCol = -1;
                    gRow = -1;
                    lItem = itemPosition;
                    string text = (sender as ListBox).Items[itemPosition].ToString();
                    if (text != "")
                        (sender as ListBox).DoDragDrop(text, DragDropEffects.Move);
                }
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if ((sender as Control).Name == SourceName)
                return;

            string value = e.Data.GetData(DataFormats.Text).ToString();
            Point cursorPosition = (sender as ListBox).PointToClient(new Point(e.X, e.Y));
            int itemPosition = (sender as ListBox).IndexFromPoint(cursorPosition);

            if (itemPosition == -1)
                (sender as ListBox).Items.Add(value);
            else
                (sender as ListBox).Items.Insert(itemPosition, value);

            if (gRow >= 0 && gCol >= 0)
                dataGridView1.Rows[gRow].Cells[gCol].Value = "";

            if (lItem >= 0)
                ((this.Controls[SourceName]) as ListBox).Items.RemoveAt(lItem);
        }

        private bool isSimple(int a)
        {
            if (a == 0) return false;
            int count = 0;
            for (int i = 1; i <= a; i++)
                if (a % i == 0) count++;
            return count <= 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Подсчет составных чисел в listBox2
            int L1 = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
                if (isSimple(Convert.ToInt32(listBox2.Items[i].ToString()))) L1++;

            // Подсчет оставшихся чисел в dataGridView1
            int DG = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value?.ToString() != "")
                        DG++;

            // Подсчет простых чисел в listBox1
            int L2 = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
                if (isSimple(Convert.ToInt32(listBox1.Items[i].ToString()))) L2++;

            // Проверка корректности распределения
            if (L1 == 0 && DG == 0 && L2 == listBox1.Items.Count)
                MessageBox.Show("Вы справились с заданием", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Вы не справились с заданием", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}