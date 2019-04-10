namespace TwentyOne_Client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Panel();
            this.lbl_banker = new System.Windows.Forms.Label();
            this.panel_Banker = new System.Windows.Forms.Panel();
            this.b_card = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.panel_Player = new System.Windows.Forms.Panel();
            this.p_card = new System.Windows.Forms.PictureBox();
            this.btn_BetClear = new System.Windows.Forms.Button();
            this.btn_Bet1 = new System.Windows.Forms.Button();
            this.btn_Bet25 = new System.Windows.Forms.Button();
            this.btn_Bet20 = new System.Windows.Forms.Button();
            this.btn_Bet5 = new System.Windows.Forms.Button();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_Bet = new System.Windows.Forms.Label();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_More = new System.Windows.Forms.Button();
            this.btn_Bet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.table.SuspendLayout();
            this.panel_Banker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_card)).BeginInit();
            this.panel_Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_card)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 448);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(644, 91);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_Port);
            this.panel1.Controls.Add(this.tb_IP);
            this.panel1.Controls.Add(this.lbl_port);
            this.panel1.Controls.Add(this.lbl_ip);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Location = new System.Drawing.Point(252, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 173);
            this.panel1.TabIndex = 2;
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(182, 36);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(36, 20);
            this.tb_Port.TabIndex = 9;
            this.tb_Port.Text = "8888";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(39, 36);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(100, 20);
            this.tb_IP.TabIndex = 8;
            this.tb_IP.Text = "127.0.0.1";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(147, 39);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(29, 13);
            this.lbl_port.TabIndex = 7;
            this.lbl_port.Text = "Port:";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(13, 39);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(20, 13);
            this.lbl_ip.TabIndex = 6;
            this.lbl_ip.Text = "IP:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(13, 89);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(77, 86);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(126, 20);
            this.tb_username.TabIndex = 4;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(91, 131);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Играть дальше";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // table
            // 
            this.table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("table.BackgroundImage")));
            this.table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.table.Controls.Add(this.lbl_banker);
            this.table.Controls.Add(this.panel_Banker);
            this.table.Controls.Add(this.lbl_Score);
            this.table.Controls.Add(this.panel_Player);
            this.table.Controls.Add(this.btn_BetClear);
            this.table.Controls.Add(this.btn_Bet1);
            this.table.Controls.Add(this.btn_Bet25);
            this.table.Controls.Add(this.btn_Bet20);
            this.table.Controls.Add(this.btn_Bet5);
            this.table.Controls.Add(this.lbl_balance);
            this.table.Controls.Add(this.lbl_Bet);
            this.table.Controls.Add(this.btn_Done);
            this.table.Controls.Add(this.btn_More);
            this.table.Controls.Add(this.btn_Bet);
            this.table.Enabled = false;
            this.table.Location = new System.Drawing.Point(2, -12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(755, 435);
            this.table.TabIndex = 3;
            // 
            // lbl_banker
            // 
            this.lbl_banker.BackColor = System.Drawing.Color.Black;
            this.lbl_banker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_banker.ForeColor = System.Drawing.Color.White;
            this.lbl_banker.Location = new System.Drawing.Point(489, 37);
            this.lbl_banker.Name = "lbl_banker";
            this.lbl_banker.Size = new System.Drawing.Size(40, 19);
            this.lbl_banker.TabIndex = 14;
            this.lbl_banker.Text = "0";
            this.lbl_banker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Banker
            // 
            this.panel_Banker.BackColor = System.Drawing.Color.Transparent;
            this.panel_Banker.Controls.Add(this.b_card);
            this.panel_Banker.Location = new System.Drawing.Point(255, 13);
            this.panel_Banker.Name = "panel_Banker";
            this.panel_Banker.Size = new System.Drawing.Size(249, 72);
            this.panel_Banker.TabIndex = 18;
            // 
            // b_card
            // 
            this.b_card.BackColor = System.Drawing.Color.White;
            this.b_card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_card.Image = ((System.Drawing.Image)(resources.GetObject("b_card.Image")));
            this.b_card.Location = new System.Drawing.Point(195, 1);
            this.b_card.Name = "b_card";
            this.b_card.Size = new System.Drawing.Size(51, 70);
            this.b_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b_card.TabIndex = 15;
            this.b_card.TabStop = false;
            this.b_card.Visible = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.BackColor = System.Drawing.Color.Black;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Score.ForeColor = System.Drawing.Color.White;
            this.lbl_Score.Location = new System.Drawing.Point(252, 229);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(40, 19);
            this.lbl_Score.TabIndex = 12;
            this.lbl_Score.Text = "0";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Player
            // 
            this.panel_Player.BackColor = System.Drawing.Color.Transparent;
            this.panel_Player.Controls.Add(this.p_card);
            this.panel_Player.Location = new System.Drawing.Point(280, 208);
            this.panel_Player.Name = "panel_Player";
            this.panel_Player.Size = new System.Drawing.Size(249, 72);
            this.panel_Player.TabIndex = 17;
            // 
            // p_card
            // 
            this.p_card.BackColor = System.Drawing.Color.White;
            this.p_card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_card.Image = ((System.Drawing.Image)(resources.GetObject("p_card.Image")));
            this.p_card.Location = new System.Drawing.Point(2, 0);
            this.p_card.Name = "p_card";
            this.p_card.Size = new System.Drawing.Size(51, 70);
            this.p_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_card.TabIndex = 13;
            this.p_card.TabStop = false;
            this.p_card.Visible = false;
            // 
            // btn_BetClear
            // 
            this.btn_BetClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_BetClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BetClear.BackgroundImage")));
            this.btn_BetClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BetClear.FlatAppearance.BorderSize = 0;
            this.btn_BetClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BetClear.Location = new System.Drawing.Point(266, 349);
            this.btn_BetClear.Name = "btn_BetClear";
            this.btn_BetClear.Size = new System.Drawing.Size(30, 30);
            this.btn_BetClear.TabIndex = 16;
            this.btn_BetClear.UseVisualStyleBackColor = false;
            this.btn_BetClear.Click += new System.EventHandler(this.btn_BetClear_Click);
            // 
            // btn_Bet1
            // 
            this.btn_Bet1.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Bet1.BackgroundImage")));
            this.btn_Bet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Bet1.FlatAppearance.BorderSize = 0;
            this.btn_Bet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bet1.Location = new System.Drawing.Point(122, 269);
            this.btn_Bet1.Name = "btn_Bet1";
            this.btn_Bet1.Size = new System.Drawing.Size(30, 30);
            this.btn_Bet1.TabIndex = 11;
            this.btn_Bet1.UseVisualStyleBackColor = false;
            this.btn_Bet1.Click += new System.EventHandler(this.btn_Bet1_Click);
            // 
            // btn_Bet25
            // 
            this.btn_Bet25.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bet25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Bet25.BackgroundImage")));
            this.btn_Bet25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Bet25.FlatAppearance.BorderSize = 0;
            this.btn_Bet25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bet25.Location = new System.Drawing.Point(226, 335);
            this.btn_Bet25.Name = "btn_Bet25";
            this.btn_Bet25.Size = new System.Drawing.Size(30, 30);
            this.btn_Bet25.TabIndex = 10;
            this.btn_Bet25.UseVisualStyleBackColor = false;
            this.btn_Bet25.Click += new System.EventHandler(this.btn_Bet25_Click);
            // 
            // btn_Bet20
            // 
            this.btn_Bet20.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bet20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Bet20.BackgroundImage")));
            this.btn_Bet20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Bet20.FlatAppearance.BorderSize = 0;
            this.btn_Bet20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bet20.Location = new System.Drawing.Point(187, 317);
            this.btn_Bet20.Name = "btn_Bet20";
            this.btn_Bet20.Size = new System.Drawing.Size(30, 30);
            this.btn_Bet20.TabIndex = 9;
            this.btn_Bet20.UseVisualStyleBackColor = false;
            this.btn_Bet20.Click += new System.EventHandler(this.btn_Bet20_Click);
            // 
            // btn_Bet5
            // 
            this.btn_Bet5.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bet5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Bet5.BackgroundImage")));
            this.btn_Bet5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Bet5.FlatAppearance.BorderSize = 0;
            this.btn_Bet5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bet5.Location = new System.Drawing.Point(152, 294);
            this.btn_Bet5.Name = "btn_Bet5";
            this.btn_Bet5.Size = new System.Drawing.Size(30, 30);
            this.btn_Bet5.TabIndex = 8;
            this.btn_Bet5.UseVisualStyleBackColor = false;
            this.btn_Bet5.Click += new System.EventHandler(this.btn_Bet5_Click);
            // 
            // lbl_balance
            // 
            this.lbl_balance.BackColor = System.Drawing.Color.Black;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_balance.ForeColor = System.Drawing.Color.White;
            this.lbl_balance.Location = new System.Drawing.Point(330, 364);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(102, 26);
            this.lbl_balance.TabIndex = 7;
            this.lbl_balance.Text = "100000000";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Bet
            // 
            this.lbl_Bet.BackColor = System.Drawing.Color.Black;
            this.lbl_Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Bet.ForeColor = System.Drawing.Color.White;
            this.lbl_Bet.Location = new System.Drawing.Point(357, 314);
            this.lbl_Bet.Name = "lbl_Bet";
            this.lbl_Bet.Size = new System.Drawing.Size(40, 19);
            this.lbl_Bet.TabIndex = 5;
            this.lbl_Bet.Text = "0";
            this.lbl_Bet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Bet.TextChanged += new System.EventHandler(this.lbl_Bet_TextChanged);
            // 
            // btn_Done
            // 
            this.btn_Done.BackColor = System.Drawing.Color.Transparent;
            this.btn_Done.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Done.BackgroundImage")));
            this.btn_Done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Done.FlatAppearance.BorderSize = 0;
            this.btn_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Done.Location = new System.Drawing.Point(499, 335);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(30, 30);
            this.btn_Done.TabIndex = 3;
            this.btn_Done.UseVisualStyleBackColor = false;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_More
            // 
            this.btn_More.BackColor = System.Drawing.Color.Transparent;
            this.btn_More.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_More.BackgroundImage")));
            this.btn_More.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_More.FlatAppearance.BorderSize = 0;
            this.btn_More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_More.Location = new System.Drawing.Point(461, 348);
            this.btn_More.Name = "btn_More";
            this.btn_More.Size = new System.Drawing.Size(30, 30);
            this.btn_More.TabIndex = 2;
            this.btn_More.UseVisualStyleBackColor = false;
            this.btn_More.Click += new System.EventHandler(this.btn_More_Click);
            // 
            // btn_Bet
            // 
            this.btn_Bet.Enabled = false;
            this.btn_Bet.Location = new System.Drawing.Point(407, 286);
            this.btn_Bet.Name = "btn_Bet";
            this.btn_Bet.Size = new System.Drawing.Size(34, 27);
            this.btn_Bet.TabIndex = 1;
            this.btn_Bet.Text = "Bet";
            this.btn_Bet.UseVisualStyleBackColor = true;
            this.btn_Bet.Click += new System.EventHandler(this.bnt_Bet_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_Continue);
            this.panel2.Location = new System.Drawing.Point(282, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 123);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 67);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(41, 91);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(129, 23);
            this.btn_Continue.TabIndex = 3;
            this.btn_Continue.Text = "Играть дальше";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.table.ResumeLayout(false);
            this.panel_Banker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.b_card)).EndInit();
            this.panel_Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_card)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel table;
        private System.Windows.Forms.Label lbl_Bet;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_More;
        private System.Windows.Forms.Button btn_Bet;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Bet1;
        private System.Windows.Forms.Button btn_Bet25;
        private System.Windows.Forms.Button btn_Bet20;
        private System.Windows.Forms.Button btn_Bet5;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.PictureBox p_card;
        private System.Windows.Forms.Label lbl_banker;
        private System.Windows.Forms.PictureBox b_card;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_BetClear;
        private System.Windows.Forms.Panel panel_Banker;
        private System.Windows.Forms.Panel panel_Player;
    }
}

