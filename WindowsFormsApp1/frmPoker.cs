using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class frmPoker : Form
    {
        PictureBox[] pic = new PictureBox[5];

        public Image GetPic(string poker_name)
        {
            return WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject(poker_name) as Image;
        }
        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
        }

        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];
        int[] poker = new int[5];
        private void InitializePoker()
        {
            // 初始化下拉選單 (Choose_type)
            Choose_type.DropDownStyle = ComboBoxStyle.DropDownList;
            Choose_type.Items.AddRange(new object[] {
            " ","皇家同花順", "同花順", "鐵支", "葫蘆", "同花", "順子", "三條", "兩對", "一對"
            });
            Choose_type.SelectedIndex = 0; // 預設選第一個
            Choose_type.Enabled = false; // 初始時禁用下拉選單

            // 初始化下注元件 (bet_money
            bet_money.Increment = 100;
            bet_money.Minimum = 0;
            bet_money.Maximum = 0; // 初始時因為還沒設定資金，最大值先設為 0
            bet_money.Enabled = false;

            principal_input.Increment = 1000; 
            principal_input.Minimum = 0;
            principal_input.Maximum = 10000000;

            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetPic("back");
                pic[i].Name = "pic" + (i + 1);
                pic[i].SizeMode = PictureBoxSizeMode.Zoom;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag = "back";

                pic[i].Size = new Size(126, 170);
                pic[i].Location = new Point(230 + ((pic[i].Width + 10) * i), 300);
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
                pic.Image = GetPic($"pic{playerPoker[index-1] + 1}");
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



        private void ShowCards()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = this.GetPic($"pic{playerPoker[i] + 1}");
            }
        }
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
                playerPoker[i] = allPoker[i];
            }
            ShowCards();

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
                    playerPoker[i] = allPoker[cardIndex];
                    pic[i].Tag = "front";
                    cardIndex++;
                }
            }
            // 禁用所有牌的點擊事件
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Enabled = false;
            }
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e) //判斷牌型
        {

            //計算本金
            int principal = int.Parse(principal_input.Text);
            int finalChange = (int)bet_money.Value*(-1);

            //下注牌型
            string selected = Choose_type.SelectedItem.ToString();

            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q","K" };
            // 計錄目前五張撲克牌的花色和點數的陣列
            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];
            // 將每張牌的顏色和點數分別存入 pokerColor 和 pokerPoint 陣列
            for (int i = 0; i < 5; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }

            // 記錄花色和點數出現次數的陣列
            int[] colorCount = new int[4];
            int[] pointCount = new int[13];
            // 統計 color 和 point 出現次數
            for (int i = 0; i < 5; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }
            // 排序 colorCount 和 pointCount 由大到小
            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);


            // 判斷是否為同花
            bool isFlush = (colorCount[0] == 5);
            // 判斷是否為五張單張
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 &&
            pointCount[3] == 1 && pointCount[4] == 1);
            // 判斷是否為差四
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            // 判斷是否為大順
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) &&
            pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            // 判斷是否為同花大順
            bool isRoyalisFlush = isFlush && isRoyal;
            // 判斷是否為同花順
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            // 判斷是否為順子
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            // 判斷是否為鐵支
            bool isFourOfAKind = (pointCount[0] == 4);
            // 判斷是否為葫蘆
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            // 判斷是否為三條
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            // 判斷是否為兩對
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            // 判斷是否為一對
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);



            string result = "";
            if (isRoyalisFlush)
            {
                result = $"{colorList[0]} 同花大順";
                if (selected == "皇家同花順")
                    finalChange *= -250;
            }
            else if (isStraightFlush)
            {
                result = $"{colorList[0]} 同花順";
                if (selected == "同花順")
                    finalChange *= -50;
            }
            else if (isStraight)
            {
                result = "順子";
                if (selected == "順子")
                    finalChange *= -4;
            }
            else if (isFourOfAKind)
            {
                result = $"{pointList[0]} 鐵支";
                if (selected == "鐵支")
                    finalChange *= -25;
            }
            else if (isFullHouse)
            {
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
                if (selected == "葫蘆")
                    finalChange *= -9;
            }
            else if (isFlush)
            {
                result = $"{colorList[0]} 同花";
                if (selected == "同花")
                    finalChange *= -6;
            }
            else if (isThreeOfAKind)
            {
                result = $"{pointList[0]} 三條";
                if (selected == "三條")
                    finalChange *= -3;
            }
            else if (isTwoPair)
            {
                result = $"{pointList[0]},{pointList[1]} 兩對";
                if (selected == "兩對")
                    finalChange *= -2;
            }
            else if (isOnePair)
            {
                result = $"{pointList[0]} 一對";
                if (selected == "一對")
                    finalChange *= -1;
            }
            else
            {
                result = "雜牌";
            }

            string moneyStatus = (finalChange >= 0) ? "得到" : "損失";
            result += $" {moneyStatus} {Math.Abs(finalChange)}\n";
            lblresult.Text = result;
            

            //重新一輪把更改本金加上去
            principal += finalChange;
            principal_input.Text = principal.ToString();
            bet_money.Maximum = principal;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;


            if (principal > 0) {
                bet_again.Enabled = true;
                bet_again.Visible = true;
            }
            else
            {
                // 1. 彈出警告視窗 (程式會停在這裡直到使用者按 OK)
                MessageBox.Show("你已經破產了！請回家洗洗睡吧，遊戲即將結束。",
                                "遊戲結束",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);

                // 2. 當使用者點掉彈窗後，執行關閉程式
                Application.Exit();
            }

            


        }

        private void bet_again_Click(object sender, EventArgs e)
        {   
            bet_again.Enabled = false;
            bet_money.Enabled = true;
            Choose_type.Enabled = true;
            bet_btn.Enabled = true;

            lblresult.Text = " ";

            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = GetPic("back");
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPoker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnDealCard.Enabled == false && bet_btn.Enabled == false && check_principal_btn.Enabled == false)
            {
                switch ((int)e.KeyChar)
                {
                    case 'q':
                        // 同花大順
                        playerPoker[0] = 51;
                        playerPoker[1] = 47;
                        playerPoker[2] = 43;
                        playerPoker[3] = 39;
                        playerPoker[4] = 3;
                        break;
                    case 'w':
                        playerPoker[0] = 37;
                        playerPoker[1] = 33;
                        playerPoker[2] = 29;
                        playerPoker[3] = 25;
                        playerPoker[4] = 21;
                        break;
                    case 'e':
                        // 同花
                        playerPoker[0] = 50;
                        playerPoker[1] = 38;
                        playerPoker[2] = 34;
                        playerPoker[3] = 22;
                        playerPoker[4] = 18;
                        break;
                    case 'r':
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 38;
                        playerPoker[3] = 37;
                        playerPoker[4] = 36;
                        break;

                }
                ShowCards();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void bet_money_KeyUp(object sender, KeyEventArgs e)
        {
            // 因為打字時 bet_money.Value 可能還沒更新
            // 我們直接抓取輸入框裡面的「文字」來判斷最準確
            if (int.TryParse(bet_money.Text, out int currentBet))
            {
                if (currentBet % 100 != 0)
                {
                    currentBet -= currentBet % 100;
                }
                bet_money.Text = currentBet.ToString();
                UpdateBetRemark(currentBet);
                

            }
        }

        // 為了讓箭頭點擊也能觸發，ValueChanged 也要呼叫同一個 function
        private void bet_money_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(bet_money.Text, out int currentBet);
            if (currentBet % 100 != 0)
            {
                currentBet -= currentBet % 100;
            }
            bet_money.Text = currentBet.ToString();
            UpdateBetRemark((int)bet_money.Value);
        }

        // 統一處理建議文字的邏輯
        private void UpdateBetRemark(int amount)
        {
            bet_money_remark.Visible = true;
            int principal = int.Parse(principal_input.Text);
            if (amount <= 0)
            {
                bet_money_remark.Text = "不入虎穴，焉得虎子？請輸入金額";
                bet_money_remark.ForeColor = Color.Gray;
            }
            else if (amount < principal/2)
            {
                bet_money_remark.Text = "小賭怡情，這點錢還不夠買便當";
                bet_money_remark.ForeColor = Color.Black;
            }
            else if (amount >= principal / 2 && amount < principal)
            {
                bet_money_remark.Text = "看來你很有自信，祝你好運";
                bet_money_remark.ForeColor = Color.Blue;
            }
            else
            {
                bet_money_remark.Text = "梭哈啦！這波贏了直接退休";
                bet_money_remark.ForeColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. 取得目前選中的內容
            string selected = Choose_type.SelectedItem.ToString();

            // 2. 如果選的不是空格，且清單中還留著那個空格，就把空格刪掉
            if (selected != " " && Choose_type.Items.Contains(" "))
            {
                Choose_type.Items.Remove(" ");
                // 刪除後，因為 Item 順序變了，selected 可能會跳掉，
                // 但 WinForms 通常會自動抓回正確的文字。
            }

            Choose_type_remark.Visible = true;

            // 3. 根據選到的牌型，給予不同的建議
            switch (selected)
            {
                case "皇家同花順":
                    Choose_type_remark.ForeColor = Color.Red;
                    Choose_type_remark.Text = "這是神蹟！傾家蕩產也要跟進！";
                    break;
                case "同花順":
                    Choose_type_remark.ForeColor = Color.Orange;
                    Choose_type_remark.Text = "非常強大的牌型，勝利就在眼前！";
                    break;
                case "鐵支":
                    Choose_type_remark.ForeColor = Color.Yellow;
                    Choose_type_remark.Text = "鐵支在此，誰敢不服？";
                    break;
                case "葫蘆":
                    Choose_type_remark.ForeColor = Color.Yellow;
                    Choose_type_remark.Text = "滿堂紅，這是非常穩健的牌型。";
                    break;
                case "同花":
                    Choose_type_remark.ForeColor = Color.Yellow;
                    Choose_type_remark.Text = "顏色一致，賞心悅目，勝率不低。";
                    break;
                case "順子":
                    Choose_type_remark.ForeColor = Color.LightBlue;
                    Choose_type_remark.Text = "步步高升，可以嘗試博一把。";
                    break;
                case "三條":
                    Choose_type_remark.ForeColor = Color.LightBlue;
                    Choose_type_remark.Text = "有點機會，但還是要小心陷阱。";
                    break;
                case "兩對":
                    Choose_type_remark.ForeColor = Color.LightBlue;
                    Choose_type_remark.Text = "普普通通，建議觀望一下。";
                    break;
                case "一對":
                    Choose_type_remark.ForeColor = Color.Black;
                    Choose_type_remark.Text = "你甘願這樣就此放棄機會嗎？";
                    break;
                default:
                    Choose_type_remark.Text = "";
                    break;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void principal_input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal_remark.Visible = true;

            int principal = int.Parse(principal_input.Text);

            if (principal != 0)
            {
                bet_money.Maximum = principal;
                bet_money.Enabled = true;
                Choose_type.Enabled = true;
                check_principal_btn.Enabled = false;
                principal_input.Enabled = false;
                bet_btn.Enabled = true;
                principal_remark.Visible = false;
            }
            else
            {
                principal_remark.ForeColor = Color.Red;
                principal_remark.Text = "本金不能為0";
            }

        }

        private void principal_input_Leave(object sender, EventArgs e)
        {
            
        }

        private void bet_btn_Click(object sender, EventArgs e)
        {
            
            string selectedHand = Choose_type.SelectedItem.ToString();
            int principal = int.Parse(principal_input.Text);

            if (selectedHand == " ")
            {
                bet_btn_remark.Visible = true;
                bet_btn_remark.Text = "押注錯誤，請選定牌型與下注金額";
            }
            else
            {
                //下注完成不能更改
                bet_money.Enabled = false ;
                Choose_type.Enabled= false ;
                bet_btn.Enabled= false ;


                bet_btn_remark.Visible = false;
                btnDealCard.Enabled = true; 
            }


        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void groupbet_Enter(object sender, EventArgs e)
        {

        }

        private void principal_input_KeyUp(object sender, KeyEventArgs e)
        {
            // 因為打字時 bet_money.Value 可能還沒更新
            // 我們直接抓取輸入框裡面的「文字」來判斷最準確
            if (int.TryParse(principal_input.Text, out int principal))
            {
                if (principal % 100 != 0)
                {
                    principal -= principal % 100;
                }
                principal_input.Text = principal.ToString();
            }
        }
        private void principal_input_ValueChanged(object sender, EventArgs e)
        {
            bool validprincipal = int.TryParse(principal_input.Text, out int principal);
            if (validprincipal)
            {
                if (principal % 100 != 0)
                {
                    principal -= principal % 100;
                }
            }
            
            principal_input.Text = principal.ToString();
        }

        private void bet_btn_remark_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
