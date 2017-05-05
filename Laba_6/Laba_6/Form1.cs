using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_6
{
    public partial class Form1 : Form
    {
        ArrayList M = new ArrayList();
        int[] Znach= new int[3];
        int i = 0;
        int f = -1;
        bool r = true;
        delegate int Operation(int ch1, int ch2);
        Operation OP;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((i == 0 && Znach[i] == 0) || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10;
            textBox1.Text += "0";
            r = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((i == 0 && Znach[i] == 0) || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10+1;
            textBox1.Text += "1";
            r = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((i == 0 && Znach[i] == 0) || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10+2;
            textBox1.Text += "2";
            r = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((i == 0 && Znach[i] == 0) || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10+3;
            textBox1.Text += "3";
            r = false;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Znach[i] == 0 || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10 + 4;
            textBox1.Text += "4";
            r = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Znach[i] == 0 || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10 + 5;
            textBox1.Text += "5";
            r = false;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Znach[i] == 0 || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10 + 6;
            textBox1.Text += "6";
            r = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (Znach[i] == 0 || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10 + 7;
            textBox1.Text += "7";
            r = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Znach[i] == 0 || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10 + 8;
            textBox1.Text += "8";
            r = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (Znach[i] == 0 || r) textBox1.Text = "";
            if (r) Znach[i] = 0; ;
            Znach[i] = Znach[i] * 10 + 9;
            textBox1.Text += "9";
            r = false;
        }
        //Память
        private void button18_Click(object sender, EventArgs e)
        {
            if (M.Count != 0)
            {
                f++;
                if (f >= M.Count) f = 0;
                Znach[i] = (int)M[f];
                r = false;
                textBox1.Text = Znach[i].ToString();
            }
        }
        //Добавить в память
        private void button17_Click(object sender, EventArgs e)
        {
          //  M.AddFirst;
            M.Add(Znach[i]);
        }
        //Удалить из памяти
        private void button19_Click(object sender, EventArgs e)
        {
            if(M.Count!=0)
            M.RemoveAt(f);
            textBox1.Text = "";
        }
        //+
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (i != 1)
                {
                    OP = new Operation(
                    (int ch1, int ch2) =>
                    {
                        return ch1 + ch2;
                    }
                    );
                    textBox2.Text = Znach[i].ToString();
                    textBox2.Text += "+";
                    textBox1.Text = "";
                    i = 1;
                    r = true;
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Error";
            }
        }
        // /
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (i != 1)
                {
                    OP = new Operation(
                      (int ch1, int ch2) =>
                      {
                          return ch1 / ch2;
                      }
                      );
                    textBox2.Text = Znach[i].ToString();
                    textBox2.Text += "/";
                    textBox1.Text = "";
                    i = 1;
                    r = true;
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Error";
            }
        }
        // -
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (i != 1)
                {
                    OP = new Operation(
                    (int ch1, int ch2) =>
                    {
                        return ch1 - ch2;
                    }
                    );
                    textBox2.Text = Znach[i].ToString();
                    textBox2.Text += "-";
                    textBox1.Text = "";
                    i = 1;
                    r = true;
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Error";
            }
        }
        // ^
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (i != 1)
                {
                    OP = new Operation(
                    (int ch1, int ch2) =>
                    {
                        return (int)Math.Pow((double)ch1 , (double)ch2);
                    }
                    );
                    textBox2.Text = Znach[i].ToString();
                    textBox2.Text += "^";
                    textBox1.Text = "";
                    i = 1;
                    r = true;
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Error";
            }
        }
        // *
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (i != 1)
                {
                    OP = new Operation(
                    (int ch1, int ch2) =>
                    {
                        return ch1 * ch2;
                    }
                    );
                    textBox2.Text = Znach[i].ToString();
                    textBox2.Text += "*";
                    textBox1.Text = "";
                    i = 1;
                    r = true;
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Error";
            }
        }
        // =
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (!r)
                {
                    Znach[2] = OP(Znach[0], Znach[1]);
                    i = 0;
                    textBox2.Text += Znach[1].ToString();
                    textBox2.Text += "=";
                    textBox1.Text = Znach[2].ToString();
                    Znach[0] = Znach[2];
                    Znach[1] = 0;
                    Znach[2] = 0;
                    r = true;
                }
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
            }
        }
        //Удаление
        private void button20_Click(object sender, EventArgs e)
        {
            Znach[0] = 0;
            Znach[1] = 0;
            Znach[2] = 0;
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
