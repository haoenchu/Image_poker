using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class frmPoker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.bet_again = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.groupbet = new System.Windows.Forms.GroupBox();
            this.bet_btn_remark = new System.Windows.Forms.Label();
            this.principal_input = new System.Windows.Forms.NumericUpDown();
            this.Choose_type_remark = new System.Windows.Forms.Label();
            this.bet_money_remark = new System.Windows.Forms.Label();
            this.principal_remark = new System.Windows.Forms.Label();
            this.Choose_type = new System.Windows.Forms.ComboBox();
            this.bet_money = new System.Windows.Forms.NumericUpDown();
            this.bet_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.check_principal_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPoker.SuspendLayout();
            this.groupbet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principal_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet_money)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Controls.Add(this.bet_again);
            this.grpPoker.Controls.Add(this.lblresult);
            this.grpPoker.Controls.Add(this.btnCheck);
            this.grpPoker.Controls.Add(this.btnChangeCard);
            this.grpPoker.Controls.Add(this.btnDealCard);
            this.grpPoker.Controls.Add(this.groupbet);
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(27, 22);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(690, 442);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            this.grpPoker.Enter += new System.EventHandler(this.table_Enter);
            // 
            // bet_again
            // 
            this.bet_again.Enabled = false;
            this.bet_again.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bet_again.Location = new System.Drawing.Point(564, 398);
            this.bet_again.Name = "bet_again";
            this.bet_again.Size = new System.Drawing.Size(105, 38);
            this.bet_again.TabIndex = 16;
            this.bet_again.Text = "再來一次";
            this.bet_again.UseVisualStyleBackColor = true;
            this.bet_again.Click += new System.EventHandler(this.bet_again_Click);
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblresult.Location = new System.Drawing.Point(274, 395);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(284, 41);
            this.lblresult.TabIndex = 3;
            this.lblresult.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(164, 395);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 41);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(92, 395);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(66, 41);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Enabled = false;
            this.btnDealCard.Location = new System.Drawing.Point(20, 395);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(66, 41);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // groupbet
            // 
            this.groupbet.Controls.Add(this.bet_btn_remark);
            this.groupbet.Controls.Add(this.principal_input);
            this.groupbet.Controls.Add(this.Choose_type_remark);
            this.groupbet.Controls.Add(this.bet_money_remark);
            this.groupbet.Controls.Add(this.principal_remark);
            this.groupbet.Controls.Add(this.Choose_type);
            this.groupbet.Controls.Add(this.bet_money);
            this.groupbet.Controls.Add(this.bet_btn);
            this.groupbet.Controls.Add(this.label3);
            this.groupbet.Controls.Add(this.check_principal_btn);
            this.groupbet.Controls.Add(this.label2);
            this.groupbet.Controls.Add(this.label1);
            this.groupbet.Location = new System.Drawing.Point(19, 244);
            this.groupbet.Name = "groupbet";
            this.groupbet.Size = new System.Drawing.Size(650, 130);
            this.groupbet.TabIndex = 2;
            this.groupbet.TabStop = false;
            this.groupbet.Text = "下注";
            this.groupbet.Enter += new System.EventHandler(this.groupbet_Enter);
            // 
            // bet_btn_remark
            // 
            this.bet_btn_remark.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bet_btn_remark.ForeColor = System.Drawing.Color.Red;
            this.bet_btn_remark.Location = new System.Drawing.Point(232, 107);
            this.bet_btn_remark.Name = "bet_btn_remark";
            this.bet_btn_remark.Size = new System.Drawing.Size(189, 17);
            this.bet_btn_remark.TabIndex = 15;
            this.bet_btn_remark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bet_btn_remark.Visible = false;
            // 
            // principal_input
            // 
            this.principal_input.Location = new System.Drawing.Point(87, 27);
            this.principal_input.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.principal_input.Name = "principal_input";
            this.principal_input.Size = new System.Drawing.Size(110, 35);
            this.principal_input.TabIndex = 14;
            this.principal_input.ValueChanged += new System.EventHandler(this.principal_input_ValueChanged);
            // 
            // Choose_type_remark
            // 
            this.Choose_type_remark.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Choose_type_remark.ForeColor = System.Drawing.Color.Red;
            this.Choose_type_remark.Location = new System.Drawing.Point(418, 66);
            this.Choose_type_remark.Name = "Choose_type_remark";
            this.Choose_type_remark.Size = new System.Drawing.Size(218, 17);
            this.Choose_type_remark.TabIndex = 13;
            this.Choose_type_remark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bet_money_remark
            // 
            this.bet_money_remark.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bet_money_remark.ForeColor = System.Drawing.Color.Red;
            this.bet_money_remark.Location = new System.Drawing.Point(201, 66);
            this.bet_money_remark.Name = "bet_money_remark";
            this.bet_money_remark.Size = new System.Drawing.Size(206, 17);
            this.bet_money_remark.TabIndex = 12;
            this.bet_money_remark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bet_money_remark.Visible = false;
            this.bet_money_remark.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // principal_remark
            // 
            this.principal_remark.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.principal_remark.ForeColor = System.Drawing.Color.Red;
            this.principal_remark.Location = new System.Drawing.Point(11, 66);
            this.principal_remark.Name = "principal_remark";
            this.principal_remark.Size = new System.Drawing.Size(176, 17);
            this.principal_remark.TabIndex = 11;
            this.principal_remark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.principal_remark.Visible = false;
            this.principal_remark.Click += new System.EventHandler(this.label4_Click);
            // 
            // Choose_type
            // 
            this.Choose_type.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Choose_type.FormattingEnabled = true;
            this.Choose_type.Location = new System.Drawing.Point(515, 27);
            this.Choose_type.Name = "Choose_type";
            this.Choose_type.Size = new System.Drawing.Size(121, 32);
            this.Choose_type.TabIndex = 10;
            this.Choose_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bet_money
            // 
            this.bet_money.Enabled = false;
            this.bet_money.Location = new System.Drawing.Point(297, 28);
            this.bet_money.Name = "bet_money";
            this.bet_money.Size = new System.Drawing.Size(110, 35);
            this.bet_money.TabIndex = 9;
            this.bet_money.ValueChanged += new System.EventHandler(this.bet_money_ValueChanged);
            // 
            // bet_btn
            // 
            this.bet_btn.Enabled = false;
            this.bet_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bet_btn.Location = new System.Drawing.Point(121, 86);
            this.bet_btn.Name = "bet_btn";
            this.bet_btn.Size = new System.Drawing.Size(105, 38);
            this.bet_btn.TabIndex = 8;
            this.bet_btn.Text = "確認下注";
            this.bet_btn.UseVisualStyleBackColor = true;
            this.bet_btn.Click += new System.EventHandler(this.bet_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "下注牌型";
            // 
            // check_principal_btn
            // 
            this.check_principal_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.check_principal_btn.Location = new System.Drawing.Point(11, 86);
            this.check_principal_btn.Name = "check_principal_btn";
            this.check_principal_btn.Size = new System.Drawing.Size(104, 38);
            this.check_principal_btn.TabIndex = 4;
            this.check_principal_btn.Text = "確認總資金";
            this.check_principal_btn.UseVisualStyleBackColor = true;
            this.check_principal_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "下注金額";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "總資金";
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 494);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Name = "frmPoker";
            this.Text = "frmPoker";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpPoker.ResumeLayout(false);
            this.groupbet.ResumeLayout(false);
            this.groupbet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principal_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet_money)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private Button btnCheck;
        private Button btnChangeCard;
        private Button btnDealCard;
        private Label lblresult;
        private GroupBox groupbet;
        private Label label1;
        private Label label2;
        private Button check_principal_btn;
        private Button bet_btn;
        private Label label3;
        private NumericUpDown bet_money;
        private ComboBox Choose_type;
        private Label principal_remark;
        private Label Choose_type_remark;
        private Label bet_money_remark;
        private NumericUpDown principal_input;
        private Label bet_btn_remark;
        private Button bet_again;
    }
}