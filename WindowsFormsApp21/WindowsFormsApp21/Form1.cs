using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] mas = textBox1.Lines;
            string[] mas1 = mas.Distinct().ToArray();
            List <int> mas_sch = new List<int>();
            foreach (string s1 in mas1)
            {
                int sch = 0;
                foreach (string s2 in mas)
                {
                    if (s1 == s2)
                    {
                        sch++;
                    }
                }
                mas_sch.Add(sch);                
            }
            for (int i = 0; i < mas_sch.Count; i++)
                {
                if (mas_sch[i] == mas_sch.Max())
                    {
                    listBox1.Items.Add(mas1[i]);
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
