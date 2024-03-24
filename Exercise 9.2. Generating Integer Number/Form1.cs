using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_9._2.Generating_Integer_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            listBox1.Items.Clear();
            int n = 0;
            while(n < 10)
            {
                int s = r.Next(100);
                if(s % 2 == 1)
                {
                    listBox1.Items.Add(s.ToString());
                    n++;
                }
            }
        }
    }
}
