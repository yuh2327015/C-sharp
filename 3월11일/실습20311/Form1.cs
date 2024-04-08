using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 실습20311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1,x2,y2;
        int figure = 0;
        Pen pen = new Pen(Color.Black, 10);

        private void button2_Click(object sender, EventArgs e)
        {
           pen.Color = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            figure = 2;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            Graphics g = CreateGraphics();
            if (figure == 0)
                g.DrawLine(pen, x1, y1, x2, y2);
            else if (figure == 1) g.DrawArc(pen, new Rectangle(x1, y1, (x2 - x1), (y2 - y1)), 0, 360);
            else
                g.DrawRectangle(pen,x1,y1,Math.Abs(x2-x1),Math.Abs(y2-y1));
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            figure = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            figure = 0;
        }


    }
}
