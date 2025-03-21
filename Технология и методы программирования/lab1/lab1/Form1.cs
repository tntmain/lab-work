using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EditTextListBox(string text)
        {
            //listBox1.Text = text;
            listBox1.Items.Add(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Введите число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите единицу измерения из выпадающего спика", $"Ошибка: {comboBox1.SelectedIndex} !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButton1.Checked == false 
                && radioButton2.Checked == false
                && radioButton3.Checked == false 
                && radioButton4.Checked == false)
            {
                MessageBox.Show("Выберите единицу измерения, в которуюнеобходимоконвертировать", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            double ch = Convert.ToDouble(textBox1.Text);
            int key = comboBox1.SelectedIndex;
            string text = "";
            switch (key)
            {
                case 1:
                    if (radioButton1.Checked == true)
                    {
                        ch *= 1000;
                        text = $"{Convert.ToDouble(textBox1.Text)} км = {ch} м.";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton2.Checked == true)
                    {
                        text = $"{Convert.ToDouble(textBox1.Text)} км = {ch} км.";
                        label1.Text = text; 
                        EditTextListBox(text);
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch *= 3280.84;
                        text = $"{Convert.ToDouble(textBox1.Text)} км = {ch} футы(ов).";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton4.Checked == true)
                    {
                        ch *= 39370.08;
                        text = $"{Convert.ToDouble(textBox1.Text)} км = {ch} дюймы(ов).";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    break;
                case 2:
                    if (radioButton1.Checked == true)
                    {
                        ch *= 0.025;
                        text = $"{Convert.ToDouble(textBox1.Text)} дюймы(ов) = {ch} м.";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch *= 0.000025;
                        text = $"{Convert.ToDouble(textBox1.Text)} дюймы(ов) = {ch} км.";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch *= 0.083;
                        text = $"{Convert.ToDouble(textBox1.Text)} дюймы(ов) = {ch} футы(ов).";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton4.Checked == true)
                    {
                        text = $"{Convert.ToDouble(textBox1.Text)} дюймы(ов) = {ch} дюймы(ов)";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    break;
                case 3:
                    if (radioButton1.Checked == true)
                    {
                        ch *= 0.3048;
                        text = $"{Convert.ToDouble(textBox1.Text)} футы(ов) = {ch} м.";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch *= 0.0003048;
                        text = $"{Convert.ToDouble(textBox1.Text)} футы(ов) = {ch} км.";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton3.Checked == true)
                    {
                        text = $"{Convert.ToDouble(textBox1.Text)} футы(ов) = {ch} футы(ов).";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton4.Checked == true)
                    {
                        ch *= 12;
                        text = $"{Convert.ToDouble(textBox1.Text)} футы(ов) = {ch} дюймы(ов)";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    break;
                default:
                    if (radioButton1.Checked == true)
                    {
                        text = $"{Convert.ToDouble(textBox1.Text)} м = {ch} м.";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton2.Checked == true)
                    {
                        ch *= 0.001;
                        text = $"{Convert.ToDouble(textBox1.Text)} м = {ch} км."; 
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton3.Checked == true)
                    {
                        ch *= 3.28;
                        text = $"{Convert.ToDouble(textBox1.Text)} м = {ch} футы(ов).";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    if (radioButton4.Checked == true)
                    {
                        ch *= 39.37;
                        text = $"{Convert.ToDouble(textBox1.Text)} м = {ch} дюймы(ов).";
                        label1.Text = text;
                        EditTextListBox(text);
                    }
                    break;

            }

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
