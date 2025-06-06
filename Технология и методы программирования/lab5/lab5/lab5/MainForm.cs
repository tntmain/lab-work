using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab5
{
    public partial class MainForm : Form
    {
        private SQLiteConnection SQLiteConn;
        private DataTable dTable;

        public MainForm()
        {
            InitializeComponent();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SQLiteConn = new SQLiteConnection();
            dTable = new DataTable();
        }

        private bool OpenDBFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Файлы базы данных (*.db)|*.db|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SQLiteConn = new SQLiteConnection("Data Source=" + openFileDialog.FileName + ";Version=3;");
                try
                {
                    SQLiteConn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        private void GetTableNames()
        {
            string SQLQuery = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
            SQLiteCommand command = new SQLiteCommand(SQLQuery, SQLiteConn);
            SQLiteDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
        }

        private string SQL_AllTable()
        {
            return "SELECT * FROM [" + comboBox1.SelectedItem + "] ORDER BY Id;";
        }

        private string SQL_FilterByManufacturer()
        {
            return "SELECT * FROM [" + comboBox1.SelectedItem + "] WHERE Manufacturer = '" + comboBox3.SelectedItem + "';";
        }

        private string SQL_FilterByQuantity()
        {
            return "SELECT * FROM [" + comboBox1.SelectedItem + "] WHERE Quantity <= 2;";
        }

        private void ShowTable(string SQLQuery)
        {
            dTable.Clear();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(SQLQuery, SQLiteConn);
            adapter.Fill(dTable);

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            for (int col = 0; col < dTable.Columns.Count; col++)
            {
                string ColName = dTable.Columns[col].ColumnName;
                dataGridView1.Columns.Add(ColName, ColName);
                dataGridView1.Columns[col].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int row = 0; row < dTable.Rows.Count; row++)
            {
                dataGridView1.Rows.Add(dTable.Rows[row].ItemArray);
            }
        }

        private void GetTableColumns()
        {
            string SQLQuery = "PRAGMA table_info('" + comboBox1.SelectedItem + "');";
            SQLiteCommand command = new SQLiteCommand(SQLQuery, SQLiteConn);
            SQLiteDataReader reader = command.ExecuteReader();
            comboBox2.Items.Clear();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[1].ToString());
            }
        }

        private void GetManufacturers()
        {
            comboBox3.Items.Clear();
            for (int row = 0; row < dTable.Rows.Count; row++)
            {
                string manufacturer = dTable.Rows[row]["Manufacturer"].ToString();
                if (!comboBox3.Items.Contains(manufacturer))
                {
                    comboBox3.Items.Add(manufacturer);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenDBFile())
            {
                GetTableNames();
                comboBox1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите таблицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;

            ShowTable(SQL_AllTable());
            GetTableColumns();
            GetManufacturers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите поле для расчета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double max = Convert.ToDouble(dTable.Rows[0][comboBox2.SelectedIndex]);
                double min = max;
                double sum = 0;

                for (int row = 0; row < dTable.Rows.Count; row++)
                {
                    double value = Convert.ToDouble(dTable.Rows[row][comboBox2.SelectedIndex]);
                    if (value > max) max = value;
                    if (value < min) min = value;
                    sum += value;
                }

                string message = "";
                if ((sender as System.Windows.Forms.Button).Name == "button3")
                    message = $"Минимальное значение в поле {comboBox2.Text} = {min}";
                else if ((sender as System.Windows.Forms.Button).Name == "button4")
                    message = $"Максимальное значение в поле {comboBox2.Text} = {max}";
                else if ((sender as System.Windows.Forms.Button).Name == "button5")
                    message = $"Среднее значение в поле {comboBox2.Text} = {sum / dTable.Rows.Count}";
                else if ((sender as System.Windows.Forms.Button).Name == "button6")
                    message = $"Сумма значений в поле {comboBox2.Text} = {sum}";

                MessageBox.Show(message, "Расчеты", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Поле не является числовым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked && comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите производителя товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked)
                ShowTable(SQL_AllTable());
            else if (radioButton2.Checked)
                ShowTable(SQL_FilterByManufacturer());
            else if (radioButton3.Checked)
                ShowTable(SQL_FilterByQuantity());
        }
    }
}