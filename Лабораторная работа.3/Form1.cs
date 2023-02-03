using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Лабораторная_работа._3
{
    public partial class Form1 : Form
    {
        int focus;
        int act;
        Fraction f1, f2, f;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar)&& !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            focus = 1;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            focus = 2;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            focus = 3;
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            focus = 4;
        }

        private void True(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "1";
            else if (focus == 2)
                textBox2.Text += "1";
            else if (focus == 3)
                textBox3.Text += "1";
            else if (focus == 4)
                textBox4.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "2";
            else if (focus == 2)
                textBox2.Text += "2";
            else if (focus == 3)
                textBox3.Text += "2";
            else if (focus == 4)
                textBox4.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "3";
            else if (focus == 2)
                textBox2.Text += "3";
            else if (focus == 3)
                textBox3.Text += "3";
            else if (focus == 4)
                textBox4.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "4";
            else if (focus == 2)
                textBox2.Text += "4";
            else if (focus == 3)
                textBox3.Text += "4";
            else if (focus == 4)
                textBox4.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "5";
            else if (focus == 2)
                textBox2.Text += "5";
            else if (focus == 3)
                textBox3.Text += "5";
            else if (focus == 4)
                textBox4.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "6";
            else if (focus == 2)
                textBox2.Text += "6";
            else if (focus == 3)
                textBox3.Text += "6";
            else if (focus == 4)
                textBox4.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "7";
            else if (focus == 2)
                textBox2.Text += "7";
            else if (focus == 3)
                textBox3.Text += "7";
            else if (focus == 4)
                textBox4.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "8";
            else if (focus == 2)
                textBox2.Text += "8";
            else if (focus == 3)
                textBox3.Text += "8";
            else if (focus == 4)
                textBox4.Text += "8";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            act = 1;
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Ошибка! Введите числа!");
            else if (textBox2.Text == "0")
                MessageBox.Show("Ошибка! Деление на 0 запрещено!");
            else
            {
                int t = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                f1 = new Fraction(t, b);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            act = 2;
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Ошибка! Введите числа!");
            else if (textBox2.Text == "0")
                MessageBox.Show("Ошибка! Деление на 0 запрещено!");
            else
            {
                int t = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                f1 = new Fraction(t, b);
            }
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            act = 3;
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Ошибка! Введите числа!");
            else if (textBox2.Text == "0")
                MessageBox.Show("Ошибка! Деление на 0 запрещено!");
            else
            {
                int t = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                f1 = new Fraction(t, b);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            act = 4;
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Ошибка! Введите числа!");
            else if (textBox2.Text == "0")
                MessageBox.Show("Ошибка! Деление на 0 запрещено!");
            else
            {
                int t = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                f1 = new Fraction(t, b);
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Ошибка! Введите числа!");
            else if (textBox4.Text == "0")
                MessageBox.Show("Ошибка! Деление на 0 запрещено!");
            else
            {
                int t = Int32.Parse(textBox3.Text);
                int b = Int32.Parse(textBox4.Text);
                f2 = new Fraction(t, b);
                if (act == 1)
                {
                    f = f1.plus(f2);
                    textBox5.Text = f.GetTop().ToString();
                    textBox6.Text = f.GetBottom().ToString();
                }
                if (act == 2)
                {
                    f = f1.minus(f2);
                    textBox5.Text = f.GetTop().ToString();
                    textBox6.Text = f.GetBottom().ToString();
                }
                if (act == 3)
                {
                    f = f1.mult(f2);
                    textBox5.Text = f.GetTop().ToString();
                    textBox6.Text = f.GetBottom().ToString();
                }
                if (act == 4)
                {
                    if (textBox3.Text == "0")
                        MessageBox.Show("Ошибка! Деление на 0 запрещено!");
                    else
                    {
                        f = f1.div(f2);
                        textBox5.Text = f.GetTop().ToString();
                        textBox6.Text = f.GetBottom().ToString();
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "9";
            else if (focus == 2)
                textBox2.Text += "9";
            else if (focus == 3)
                textBox3.Text += "9";
            else if (focus == 4)
                textBox4.Text += "9";
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (focus == 1)
                textBox1.Text += "0";
            else if (focus == 2)
                textBox2.Text += "0";
            else if (focus == 3)
                textBox3.Text += "0";
            else if (focus == 4)
                textBox4.Text += "0";
        }
    }
}
