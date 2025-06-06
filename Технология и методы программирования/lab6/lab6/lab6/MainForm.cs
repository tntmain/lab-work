using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeMatrixControls();
        }

        private void InitializeMatrixControls()
        {
            
            ConfigureDataGridView(dataGridView1); 
            ConfigureDataGridView(dataGridView2); 
            ConfigureDataGridView(dataGridView3); 

            
            UpdateMatrixSizes();
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgv.MultiSelect = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;  
            dgv.AllowDrop = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        private void UpdateMatrixSizes()
        {
            int rowsA = (int)numericUpDownRowsA.Value;
            int colsA = (int)numericUpDownColsA.Value;
            int colsB = (int)numericUpDownColsB.Value;

            
            dataGridView1.RowCount = rowsA;
            dataGridView1.ColumnCount = colsA;

            
            dataGridView2.RowCount = colsA;
            dataGridView2.ColumnCount = colsB;

            
            dataGridView3.RowCount = rowsA;
            dataGridView3.ColumnCount = colsB;

            
            ResizeDataGridViewCells(dataGridView1);
            ResizeDataGridViewCells(dataGridView2);
            ResizeDataGridViewCells(dataGridView3);

            
            ClearMatrix(dataGridView1);
            ClearMatrix(dataGridView2);
            ClearMatrix(dataGridView3);
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            
            ResizeDataGridViewCells(dataGridView1);
            ResizeDataGridViewCells(dataGridView2);
            ResizeDataGridViewCells(dataGridView3);
        }
        private void ResizeDataGridViewCells(DataGridView dgv)
        {
            
            if (dgv.RowCount > 0 && dgv.ColumnCount > 0)
            {
                int cellWidth = dgv.Width / dgv.ColumnCount;
                int cellHeight = dgv.Height / dgv.RowCount;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.Width = cellWidth;
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = cellHeight;
                }
            }
        }

        private void SetFixedCellSizes(DataGridView dgv)
        {
            int cellWidth = 60;
            int cellHeight = 40;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.Width = cellWidth;
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = cellHeight;
            }

            dgv.Width = dgv.ColumnCount * cellWidth + 2;
            dgv.Height = dgv.RowCount * cellHeight + 2;
        }
        private void AutoResizeDataGridView(DataGridView dgv)
        {
            
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.Width = dgv.Width / dgv.ColumnCount;
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = dgv.Height / dgv.RowCount;
            }
        }

        private void ClearMatrix(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
        }

        private void numericUpDownRowsA_ValueChanged(object sender, EventArgs e)
        {
            UpdateMatrixSizes();
        }

        private void numericUpDownColsA_ValueChanged(object sender, EventArgs e)
        {
            UpdateMatrixSizes();
        }

        private void numericUpDownColsB_ValueChanged(object sender, EventArgs e)
        {
            UpdateMatrixSizes();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumericInput_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(NumericInput_KeyPress);
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumericInput_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(NumericInput_KeyPress);
        }

        private void NumericInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            
            TextBox tb = sender as TextBox;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (tb.Text.Contains(".") || tb.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!IsMatrixFilled(dataGridView1) || !IsMatrixFilled(dataGridView2))
                {
                    MessageBox.Show("Заполните обе матрицы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                double[,] matrixA = GetMatrixFromDataGridView(dataGridView1);
                double[,] matrixB = GetMatrixFromDataGridView(dataGridView2);

                
                double[,] result = MultiplyMatrices(matrixA, matrixB);

                
                DisplayMatrix(result, dataGridView3);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка вычислений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsMatrixFilled(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private double[,] GetMatrixFromDataGridView(DataGridView dgv)
        {
            int rows = dgv.RowCount;
            int cols = dgv.ColumnCount;
            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    try
                    {
                        matrix[i, j] = Convert.ToDouble(dgv[j, i].Value.ToString().Replace(',', '.'));
                    }
                    catch
                    {
                        throw new Exception($"Некорректное значение в ячейке [{i + 1},{j + 1}]");
                    }
                }
            }
            return matrix;
        }

        private double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);
            double[,] result = new double[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return result;
        }

        private void DisplayMatrix(double[,] matrix, DataGridView dgv)
        {
            ClearMatrix(dgv);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dgv[j, i].Value = matrix[i, j].ToString("0.##");
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearMatrix(dataGridView1);
            ClearMatrix(dataGridView2);
            ClearMatrix(dataGridView3);
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            AutoResizeDataGridView(dataGridView1);
        }

        private void dataGridView2_Resize(object sender, EventArgs e)
        {
            AutoResizeDataGridView(dataGridView2);
        }

        private void dataGridView3_Resize(object sender, EventArgs e)
        {
            AutoResizeDataGridView(dataGridView3);
        }
    }
}