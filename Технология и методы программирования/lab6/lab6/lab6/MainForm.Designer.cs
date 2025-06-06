namespace lab6
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRowsA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColsA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColsB = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColsA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColsB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(200, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(300, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(200, 200);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(588, 50);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(200, 200);
            this.dataGridView3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Матрица C";
            // 
            // numericUpDownRowsA
            // 
            this.numericUpDownRowsA.Location = new System.Drawing.Point(100, 260);
            this.numericUpDownRowsA.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownRowsA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRowsA.Name = "numericUpDownRowsA";
            this.numericUpDownRowsA.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownRowsA.TabIndex = 6;
            this.numericUpDownRowsA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRowsA.ValueChanged += new System.EventHandler(this.numericUpDownRowsA_ValueChanged);
            // 
            // numericUpDownColsA
            // 
            this.numericUpDownColsA.Location = new System.Drawing.Point(162, 260);
            this.numericUpDownColsA.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownColsA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColsA.Name = "numericUpDownColsA";
            this.numericUpDownColsA.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownColsA.TabIndex = 7;
            this.numericUpDownColsA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColsA.ValueChanged += new System.EventHandler(this.numericUpDownColsA_ValueChanged);
            // 
            // numericUpDownColsB
            // 
            this.numericUpDownColsB.Location = new System.Drawing.Point(450, 260);
            this.numericUpDownColsB.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownColsB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColsB.Name = "numericUpDownColsB";
            this.numericUpDownColsB.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownColsB.TabIndex = 8;
            this.numericUpDownColsB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColsB.ValueChanged += new System.EventHandler(this.numericUpDownColsB_ValueChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(300, 300);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "=";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(425, 300);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Размерность A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Столбцы B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Матрица A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Матрица B";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.numericUpDownColsB);
            this.Controls.Add(this.numericUpDownColsA);
            this.Controls.Add(this.numericUpDownRowsA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перемножение матриц - Михеев.Д БИ-21";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColsA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColsB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsA;
        private System.Windows.Forms.NumericUpDown numericUpDownColsA;
        private System.Windows.Forms.NumericUpDown numericUpDownColsB;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}