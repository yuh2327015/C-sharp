using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0415_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "그림파일 (*.jpg,*.png,*gif,*hmn)|";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            pb_image.Image = Bitmap.FromFile(ofd.FileName);
            Image img = Bitmap.FromFile(ofd.FileName);
            this.ClientSize = img.Size;
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다.");
            this.Close();
        }
    }
}
