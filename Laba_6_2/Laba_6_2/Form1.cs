using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laba_6_2
{
    public partial class Form1 : Form
    {
        delegate  int Comparator(String s1, String s2);
        ColectionType<String> Collection;
        public Form1()
        {
            InitializeComponent();
        }
        //Сгенерировать
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(k_elem.Text);
                if (k > 0)
                {
                    Random r = new Random();
                    Collection = new ColectionType<String>(k);
                    for (int i = 0; i < k; i++)
                    {
                        String str = "";
                        int ran = r.Next(3, 10);
                        for (int j = 0; j <= ran; j++)
                        {
                            str += Convert.ToChar(r.Next(97, 123));
                        }

                        Collection.Add(str);

                    }
                    textBox1.Clear();
                    for (int i = 0; i < Collection.getCount(); i++)
                    {
                        textBox1.AppendText(Collection[i] + Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                k_elem.Text = "Error";
            }
        }
        //Asc
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Collection.Sort((String s1, String s2) =>
                {
                    if (s1.Length == s2.Length)
                    {
                        return s1.CompareTo(s2);
                    }
                    if (s1.Length > s2.Length)
                        return 1;
                    else
                        return -1;
                });
                textBox1.Clear();
                for (int i = 0; i < Collection.getCount(); i++)
                {
                    textBox1.AppendText(Collection[i] + Environment.NewLine);
                }
            }
            catch (Exception)
            {
                k_elem.Text = "Error";
            }

        }
        //Desc
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Collection.Sort((String s1, String s2) =>
                {
                    if (s1.Length == s2.Length)
                    {
                        return s2.CompareTo(s1);
                    }
                    if (s1.Length < s2.Length)
                        return 1;
                    else
                        return -1;
                });
                textBox1.Clear();
                for (int i = 0; i < Collection.getCount(); i++)
                {
                    textBox1.AppendText(Collection[i] + Environment.NewLine);
                }
            }
            catch(Exception)
            {
                k_elem.Text = "Error";
            }
        }
        /*Поиск по подстроке*/
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var colect = from string p in Collection
                             where p.Contains(subStr.Text)
                             select p;
                textBox3.Clear();
                foreach (var i in colect)
                {
                    textBox3.AppendText(i + Environment.NewLine);
                }
            }
            catch(Exception)
            {
                subStr.Text = "Error";
            }

        }
        /*Поиск по размеру*/
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBox2.Text);
                if (k > 0)
                {
                    var colect = from string p in Collection
                                 where p.Length == k
                                 select p;
                    textBox4.Clear();
                    foreach (var i in colect)
                    {
                        textBox4.AppendText(i + Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Error";
            }
        }
        /*Превые k строк*/
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBox5.Text);
                if (k > 0)
                {
                    textBox6.Clear();
                    for (int i = 0; i < k && i < Collection.getCount(); i++)
                    {
                        textBox6.AppendText(Collection[i] + Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                textBox5.Text = "Error";
            }
        }
    }
}
