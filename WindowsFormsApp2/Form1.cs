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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string b;
        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = Convert.ToString(comboBox1.SelectedIndex);
            a = "";
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || numericUpDown1.Value == 0 || comboBox1.SelectedIndex == 0 || a == "" && radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else
            {
                MessageBox.Show("Данные сохранены");
                string b = "";
                if (radioButton1.Checked == true)
                {
                    b = "Мужской";
                }
                else if (radioButton2.Checked == true)
                {
                    b = "Женский";
                }
                string writePath = @"D:\sa.txt";
                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.Write("\r\n");
                        sw.Write("Страхователь: " + "\r\n");
                        sw.Write("Фамилия: " + textBox1.Text + "\r\n");
                        sw.Write("Имя: " + textBox2.Text + "\r\n");
                        sw.Write("Дата рождения: " + dateTimePicker1.Value + "\r\n");
                        sw.Write("Пол" + b + "\r\n");
                        sw.Write("Адрес: " + "\r\n");
                        sw.Write("Город: " + textBox3.Text + "\r\n");
                        sw.Write("Улица: " + textBox4.Text + "\r\n");
                        sw.Write("Дом: " + textBox5.Text + "\r\n");
                        sw.Write("Квартира: " + textBox6.Text + "\r\n");
                        sw.Write("Страхование " + "\r\n");
                        sw.Write("Вид страхования: " + comboBox1.Text + "\r\n");
                        sw.Write("Срок страхования: " + numericUpDown1.Value + "\r\n");
                        sw.Close();
                    }
                }
                catch (Exception )
                {
                }   
             }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    



