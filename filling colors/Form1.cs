using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filling_colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen ourPen;
            Brush ourbrush;

            string pointa = textBox1.Text;
            string pointb = textBox2.Text;
            string pointc = textBox3.Text;
            string pointd = textBox4.Text;

            int aX, aY, bX, bY, cX, cY, dX, dY;

            if (!Int32.TryParse(pointa.Split(',')[0], out aX) || !Int32.TryParse(pointa.Split(',')[1], out aY))
            {
                MessageBox.Show("Invalid input for Point A");
                return;
            }

            if (!Int32.TryParse(pointb.Split(',')[0], out bX) || !Int32.TryParse(pointb.Split(',')[1], out bY))
            {
                MessageBox.Show("Invalid input for Point B");
                return;
            }

            if (!Int32.TryParse(pointc.Split(',')[0], out cX) || !Int32.TryParse(pointc.Split(',')[1], out cY))
            {
                MessageBox.Show("Invalid input for Point C");
                return;
            }

            if (!Int32.TryParse(pointd.Split(',')[0], out dX) || !Int32.TryParse(pointd.Split(',')[1], out dY))
            {
                MessageBox.Show("Invalid input for Point D");
                return;
            }

            Point a = new Point(aX, aY);
            Point b = new Point(bX, bY);
            Point c = new Point(cX, cY);
            Point d = new Point(dX, dY);
            Point[] OurPoint = new Point[] { a, b, c, d };
            Pen OurPen = new Pen(Color.Red, 6);
            SolidBrush OurBrush = new SolidBrush(Color.Coral);

            Graphics OurGraphics = this.CreateGraphics();

            OurGraphics.DrawPolygon(OurPen, OurPoint);

            OurGraphics.FillPolygon(OurBrush, OurPoint);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

