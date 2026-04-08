using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPictest : Form
    {
        public frmPictest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int picNum = random.Next(1, 53);

            this.PicTest.Image = WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject("pic"+picNum) as Image;
            label1.Text = picNum.ToString();
        }

        private void pic_Click(object sender, MouseEventArgs e)
        {
        PictureBox pic = (PictureBox)sender;
        MessageBox.Show("你選擇了" + pic.Name);
        }

        private void picTest_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNum_Click_1(object sender, EventArgs e)
        {

        }

        private void PicTest_Click_1(object sender, EventArgs e)
        {

        }
    }
}
