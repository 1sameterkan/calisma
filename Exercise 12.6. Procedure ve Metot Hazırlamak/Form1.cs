using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_12._6.Procedure_ve_Metot_Hazırlamak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void böl()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if(b == 0)
            {
                textBox3.Text = "Bölüm Belirsiz!";
                return;
            }
            textBox3.Text = (a / b).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            böl();
        }
    }
}
