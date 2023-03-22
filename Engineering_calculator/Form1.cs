using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engineering_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void ohustka1_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
                mun.Text = mun.Text.Remove(mun.Text.Length - 1, 1);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            mun.Text += (sender as Button).Text;
        }

        private void ohustka_Click(object sender, EventArgs e)
        {
            mun.Clear();
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(mun.Text);
            }
            catch (Exception) { mun.Clear(); }
            switch (znak)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    if (b == 0) { MessageBox.Show("Нельзя делить на 0"); }
                    c = a / b;
                    break;
            }
            mun.Text = c.ToString();
        }

        private void voscl_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(mun.Text);
                if (a == 0) c = 1;
                c = 1;
                for (int i = 0; i <= a; i++)
                {
                    c *= i;
                }
                mun.Text = c.ToString();
            }
            catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
        }

        private void bx2_Click(object sender, EventArgs e)
        {
            mun.Text += Math.PI;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Sin(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }

        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Cos(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {

                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Tan(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Tanh(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Cosh(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Sinh(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void sprt_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Sqrt(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void ln_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Log10(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try
                {
                    c = Convert.ToDouble(mun.Text);
                    c = Math.Log(c);
                    mun.Text = c.ToString();
                }
                catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }

        private void delX_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
            {
                try { 
                a = Convert.ToDouble(mun.Text);
                c = 1 / a;
                mun.Text = c.ToString();
                }
                catch ( Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
            }
            else
            {
                c = 0;
                mun.Text = c.ToString();
                mun.Clear();
                MessageBox.Show("Сначало введите число", "Ошибка ввода");
            }
        }
        private void PlusMins_Click(object sender, EventArgs e)
        {
            if (mun.Text != "")
                if (mun.Text[0] == '-')
                    mun.Text = mun.Text.Remove(0, 1);
                else mun.Text = '-' + mun.Text;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(mun.Text);
                znak = (sender as Button).Text[0];
                mun.Clear();
            }
            catch (Exception) { MessageBox.Show("Ошибка", "Ошибка ввода"); }
        }
    }
}
