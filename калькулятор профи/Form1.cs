using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор_профи
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;
        Random ran = new Random();
        double run, pi, ex, sin, cos, tg, lg, er;
        

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            textBox2.Text = a.ToString() + "+";
            znak = true;
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            textBox2.Text = a.ToString() + "-";
            znak = true;
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            textBox2.Text = a.ToString() + "/";
            znak = true;
         

        }

        private void button_umnog_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            textBox2.Text = a.ToString() + "*";
            znak = true;
        }

        private void button_rovn_Click(object sender, EventArgs e)
        {
            calculate();
            textBox2.Text = "";
        }

        private void calculate()
        {
            switch(count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = b.ToString();
                    if (this.textBox1.Text =="")
                    {
                        MessageBox.Show("Ничего не введено в строке");
                        return;
                    }
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    double d = double.Parse(textBox1.Text);
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += Math.Round(b, 3);
                    if (d == 0)
                    {
                        MessageBox.Show("Делить на 0 нельзя");
                        textBox1.Clear();
                        return;
                    }
                    break;
                case 4:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += Math.Round(b, 3);
                    break;

                default:
                    break;

            }
        }

        private void button_plus_min_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak==false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button_Ra_Click(object sender, EventArgs e)
        {
            run = ran.Next(999);
            textBox1.Text = run.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button_MS_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double a;
            a = Convert.ToDouble(this.textBox1.Text);
            if (!this.label3.Text.Contains("M="))
                label3.Text += "M=";
            label2.Text += a.ToString();
            
        }

        private void button_lg_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            
            double g;
            g = Convert.ToDouble(this.textBox1.Text);
            textBox1.Clear();
            if (g > 0)
            {
                lg = Math.Log10(g);
                textBox1.Text += Math.Round(lg, 2);
            }
            else
            {
                MessageBox.Show("Отрицательное число было введено");
                return;
            }
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double s;
            s = Convert.ToDouble(this.textBox1.Text);
            textBox1.Clear();
            sin = Math.Sin(s);
            textBox1.Text += Math.Round(sin, 2);
        }

        private void button_Cos_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double co;
            co = Convert.ToDouble(this.textBox1.Text);
            textBox1.Clear();
            cos = Math.Cos(co);
            textBox1.Text += Math.Round(cos, 2);
        }

        private void button_tg_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double t;
            t = Convert.ToDouble(this.textBox1.Text);
            textBox1.Clear();
            tg = Math.Tan(t);
            textBox1.Text += Math.Round(tg, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_e_Click(object sender, EventArgs e)
        {
          
            er = Math.E;
            textBox1.Text = er.ToString();
        }

        private void button_MC_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";
            this.label3.Text = "";
        }

        private void button_MR_Click(object sender, EventArgs e)
        {
            if (this.label2.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double a;
            a = Convert.ToDouble(this.label2.Text);
            this.textBox1.Text = a.ToString();
        }

        private void button_M_plus_Click(object sender, EventArgs e)
        {
            if (this.label2.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double a, b, c;
            a = Convert.ToDouble(this.label2.Text);
            b = Convert.ToDouble(this.textBox1.Text);
            c = a + b;
            this.label2.Text = "";
          
            label2.Text += Math.Round(c, 2);
        }

        private void button_M_min_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            if (this.label2.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double a, b, c;
            a = Convert.ToDouble(this.label2.Text);
            b = Convert.ToDouble(this.textBox1.Text);
            c = a - b;
            this.label2.Text = "";
            
            label2.Text += Math.Round(c, 2);
        }

        private void button_Exp_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ничего не введено в строке");
                return;
            }
            double r;
            r = Convert.ToDouble(this.textBox1.Text);
            ex = Math.Exp(r);
            textBox1.Text = ex.ToString();
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            pi = Math.PI;
            textBox1.Text = pi.ToString();
        }

        private void button_zup_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Нет необходимости в запятой");
                return;
            }
            if (!this.textBox1.Text.Contains(','))
                 textBox1.Text = textBox1.Text + ",";

        }
    }
}
