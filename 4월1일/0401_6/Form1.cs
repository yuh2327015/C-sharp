using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _0401_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random rnd = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_clock.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":"+ DateTime.Now.Second;
            int swidth = 600, sheight = 600;
            this.Text = "시계";
            this.ClientSize = new Size(sheight, swidth);
            Turtle.Delay = 50;

            int[] clockArry = new int[3];
     

            Turtle.PenSize = 2;
            for (int i = 0; i < 12; i++)
            {
                Turtle.PenColor = Color.Gray;
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(i*30);
                Turtle.Forward(150);
            }
            Turtle.PenSize = 10;
            for (int i = 0; i < clockArry.Length; i++)
            {
                int R = rnd.Next(0, 256);
                int G = rnd.Next(0, 256);
                int B = rnd.Next(0, 256);
                Turtle.PenColor = Color.FromArgb(R, G, B);
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(clockArry[i]*30);
                Turtle.Forward(170);
            }

        }
    }
}
