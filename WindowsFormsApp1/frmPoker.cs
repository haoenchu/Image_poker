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
    public partial class frmPoker : Form
    {
        PictureBox[] pic = new PictureBox[5];

        public Image GetPic(string poker_name) {
            return WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject(poker_name) as Image;
        }
        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
        }

        int[] poker = new int[5];
        private void InitializePoker()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetPic("back");
                pic[i].Name = "pic" + (i+1);
                pic[i].SizeMode = PictureBoxSizeMode.Zoom;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag = "back";

                pic[i].Size = new Size(126, 170);
                pic[i].Location = new Point(10 + ((pic[i].Width + 10) * i), 30);
                // 將 pic 丟至到 grpPorker 內
                this.grpPoker.Controls.Add(pic[i]);

                this.pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }

        private void pic_Click(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            // 取得 pic 的索引值
            int index = int.Parse(pic.Name.Replace("pic", ""));
            // 如果 pic 的 Tag 為 back，則將顯示撲克牌
            if (pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = GetPic("pic" + (poker[index] + 1));
            }
            else
            {
                pic.Tag = "back";
                pic.Image = GetPic("back");
            }
        }

        private void table_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];
        private void btnDealCard_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetPic("back");
            }
            // 初始化52張牌
            for (int i = 0; i < 52; i++)
            {
                allPoker[i] = i;
            }
            // 洗牌
            Shuffle();

            // 發牌
            for (int i = 0; i < 5; i++)
            {
                poker[i] = allPoker[i];
                pic[i].Image = GetPic("pic" + (allPoker[i] + 1));
                playerPoker[i] = allPoker[i];
            }

            for (int i = 0; i < 5; i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }
            btnChangeCard.Enabled = true;
            btnDealCard.Enabled = false;

        }

        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int cardIndex = 5;
            for (int i = 0; i < pic.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    poker[i] = allPoker[cardIndex];
                    pic[i].Image = GetPic("pic" + (poker[i] + 1));
                    pic[i].Tag = "front";
                    cardIndex++;
                }
            }
            // 禁用所有牌的點擊事件
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Enabled = false;
            }
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
