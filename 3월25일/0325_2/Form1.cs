using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _0325_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int swidth = 1400, sheight = 800;
            float curX, curY;
            int num1, num2;
            string binary1, binary2;

            this.Text = "거북이로 2진수 표현하기";
            this.ClientSize = new Size(swidth, sheight);

            num1 = int.Parse(tb_num1.Text);
            num2 = int.Parse(tb_num2.Text);

            binary1 = Convert.ToString(num1, 2);
            curX = swidth / 4;
            curY = 200;

            DrawBinaryNumber(binary1, curX, curY);

            binary2 = Convert.ToString(num2, 2);
            curX = swidth / 4;
            curY = curY - 100;

            DrawBinaryNumber(binary2, curX, curY);

            int sum = num1 + num2;
            string binarySum = Convert.ToString(sum, 2);
            curX = swidth / 4 ;
            curY = curY - 200;

            DrawBinaryNumber(binarySum, curX, curY);
        }

        private void DrawBinaryNumber(string binary, float startX, float startY)
        {
            Turtle.Delay = 200;
            float curX = startX;
            float curY = startY;

            foreach (char bit in binary)
            {
                Turtle.PenUp();
                Turtle.MoveTo(curX, curY);
                Turtle.PenDown();

                if (bit == '1')
                {
                    Turtle.PenColor = Color.Red;
                    Turtle.PenSize = 10;
                    Turtle.Forward(80);
                    
                }
                else
                {
                    Turtle.PenColor = Color.Blue;
                    Turtle.PenSize = 5;
                    Turtle.Forward(40);
                }

                curX -= 50;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turtle.Init(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int swidth = 1400, sheight = 800;
            float curX, curY;
            int num1, num2;
            string binary1, binary2;

            this.Text = "거북이로 2진수 표현하기";
            this.ClientSize = new Size(swidth, sheight);

            num1 = int.Parse(tb_num1.Text);
            num2 = int.Parse(tb_num2.Text);

            binary1 = Convert.ToString(num1, 2);
            curX = swidth / 4;
            curY = 200;

            DrawBinaryNumber(binary1, curX, curY);

            binary2 = Convert.ToString(num2, 2);
            curX = swidth / 4;
            curY = curY - 100;

            DrawBinaryNumber(binary2, curX, curY);

            int product = num1 * num2;
            string binaryProduct = Convert.ToString(product, 2);
            curX = swidth / 4;
            curY = curY - 200;

            DrawBinaryNumber(binaryProduct, curX, curY);
        }
    }
}
