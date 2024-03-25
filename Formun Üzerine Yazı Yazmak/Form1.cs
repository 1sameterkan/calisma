using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formun_Üzerine_Yazı_Yazmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics yazi;
            Pen kalem = new Pen(Color.DarkRed, 6);
            yazi = this.CreateGraphics();
            SolidBrush firca = new SolidBrush(Color.DeepPink);
            Font yazi_tipi = new Font("Arial", 50, FontStyle.Italic);
            PointF koordinat = new PointF(100, 165);
            yazi.DrawString("Merhaba Samet", yazi_tipi, firca, koordinat);

        }
    }
}
