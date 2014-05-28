using Breakout.Model;
using System.Collections.Generic;
namespace Breakout
{
    partial class NewHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewHome));
            this.pnlOnePlayer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl2Players = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlQuite = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAbou = new System.Windows.Forms.Panel();
            this.pnlAbout = new System.Windows.Forms.Label();
            this.pnlLeftArrow = new System.Windows.Forms.Panel();
            this.pnlRightArrow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlValidatePlayer = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bigPnlOnePlayer = new System.Windows.Forms.Panel();
            this.bigPnlLevel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.levelSelector = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlValidateLevel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlAb = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlOnePlayer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl2Players.SuspendLayout();
            this.pnlQuite.SuspendLayout();
            this.pnlAbou.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlValidatePlayer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.bigPnlOnePlayer.SuspendLayout();
            this.bigPnlLevel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlValidateLevel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlAb.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOnePlayer
            // 
            this.pnlOnePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.pnlOnePlayer.Controls.Add(this.label2);
            this.pnlOnePlayer.Location = new System.Drawing.Point(3, 3);
            this.pnlOnePlayer.Name = "pnlOnePlayer";
            this.pnlOnePlayer.Size = new System.Drawing.Size(244, 157);
            this.pnlOnePlayer.TabIndex = 1;
            this.pnlOnePlayer.Click += new System.EventHandler(this.pnlOnePlayer_Click);
            this.pnlOnePlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOnePlayer_Paint);
            this.pnlOnePlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlOnePlayer_MouseClick);
            this.pnlOnePlayer.MouseHover += new System.EventHandler(this.pnlOnePlayer_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "1 Joueur";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlOnePlayer_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 100);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casse Brique";
            // 
            // pnl2Players
            // 
            this.pnl2Players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.pnl2Players.Controls.Add(this.label3);
            this.pnl2Players.Location = new System.Drawing.Point(174, 166);
            this.pnl2Players.Name = "pnl2Players";
            this.pnl2Players.Size = new System.Drawing.Size(247, 157);
            this.pnl2Players.TabIndex = 3;
            this.pnl2Players.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl2Players_MouseClick);
            this.pnl2Players.MouseHover += new System.EventHandler(this.pnl2Players_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "2 Joueurs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl2Players_MouseClick);
            // 
            // pnlQuite
            // 
            this.pnlQuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(1)))));
            this.pnlQuite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlQuite.Controls.Add(this.label4);
            this.pnlQuite.Location = new System.Drawing.Point(252, 3);
            this.pnlQuite.Name = "pnlQuite";
            this.pnlQuite.Size = new System.Drawing.Size(169, 157);
            this.pnlQuite.TabIndex = 4;
            this.pnlQuite.Click += new System.EventHandler(this.pnlQuite_Click);
            this.pnlQuite.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQuite_Paint);
            this.pnlQuite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlQuite_MouseClick);
            this.pnlQuite.MouseHover += new System.EventHandler(this.pnlQuite_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quitter";
            this.label4.Click += new System.EventHandler(this.pnlQuite_Click);
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlQuite_MouseClick);
            // 
            // pnlAbou
            // 
            this.pnlAbou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(80)))), ((int)(((byte)(171)))));
            this.pnlAbou.Controls.Add(this.pnlAbout);
            this.pnlAbou.Location = new System.Drawing.Point(3, 165);
            this.pnlAbou.Name = "pnlAbou";
            this.pnlAbou.Size = new System.Drawing.Size(165, 159);
            this.pnlAbou.TabIndex = 5;
            this.pnlAbou.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlAbou_MouseClick);
            this.pnlAbou.MouseHover += new System.EventHandler(this.panel5_MouseHover);
            // 
            // pnlAbout
            // 
            this.pnlAbout.AutoSize = true;
            this.pnlAbout.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAbout.ForeColor = System.Drawing.Color.White;
            this.pnlAbout.Location = new System.Drawing.Point(3, 23);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(165, 50);
            this.pnlAbout.TabIndex = 2;
            this.pnlAbout.Text = "A propos";
            this.pnlAbout.Click += new System.EventHandler(this.label5_Click);
            this.pnlAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlAbou_MouseClick);
            // 
            // pnlLeftArrow
            // 
            this.pnlLeftArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeftArrow.BackgroundImage")));
            this.pnlLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLeftArrow.Location = new System.Drawing.Point(12, 162);
            this.pnlLeftArrow.Name = "pnlLeftArrow";
            this.pnlLeftArrow.Size = new System.Drawing.Size(64, 55);
            this.pnlLeftArrow.TabIndex = 6;
            this.pnlLeftArrow.Visible = false;
            this.pnlLeftArrow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeftArrow_Paint);
            this.pnlLeftArrow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLeftArrow_MouseClick);
            // 
            // pnlRightArrow
            // 
            this.pnlRightArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRightArrow.BackgroundImage")));
            this.pnlRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlRightArrow.Location = new System.Drawing.Point(506, 162);
            this.pnlRightArrow.Name = "pnlRightArrow";
            this.pnlRightArrow.Size = new System.Drawing.Size(64, 55);
            this.pnlRightArrow.TabIndex = 7;
            this.pnlRightArrow.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlOnePlayer);
            this.panel1.Controls.Add(this.pnl2Players);
            this.panel1.Controls.Add(this.pnlQuite);
            this.panel1.Controls.Add(this.pnlAbou);
            this.panel1.Location = new System.Drawing.Point(82, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 324);
            this.panel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(249, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 157);
            this.panel6.TabIndex = 4;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlQuite_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 50);
            this.label7.TabIndex = 1;
            this.label7.Text = "Quitter";
            this.label7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            // 
            // pnlValidatePlayer
            // 
            this.pnlValidatePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(173)))));
            this.pnlValidatePlayer.Controls.Add(this.label6);
            this.pnlValidatePlayer.Location = new System.Drawing.Point(0, 166);
            this.pnlValidatePlayer.Name = "pnlValidatePlayer";
            this.pnlValidatePlayer.Size = new System.Drawing.Size(247, 158);
            this.pnlValidatePlayer.TabIndex = 3;
            this.pnlValidatePlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jouer";
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 161);
            this.panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 41);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Joueur :";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // bigPnlOnePlayer
            // 
            this.bigPnlOnePlayer.Controls.Add(this.panel4);
            this.bigPnlOnePlayer.Controls.Add(this.pnlValidatePlayer);
            this.bigPnlOnePlayer.Controls.Add(this.panel6);
            this.bigPnlOnePlayer.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bigPnlOnePlayer.Location = new System.Drawing.Point(82, 159);
            this.bigPnlOnePlayer.Name = "bigPnlOnePlayer";
            this.bigPnlOnePlayer.Size = new System.Drawing.Size(418, 324);
            this.bigPnlOnePlayer.TabIndex = 9;
            this.bigPnlOnePlayer.Visible = false;
            // 
            // bigPnlLevel
            // 
            this.bigPnlLevel.Controls.Add(this.panel7);
            this.bigPnlLevel.Controls.Add(this.pnlValidateLevel);
            this.bigPnlLevel.Controls.Add(this.panel9);
            this.bigPnlLevel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bigPnlLevel.Location = new System.Drawing.Point(82, 162);
            this.bigPnlLevel.Name = "bigPnlLevel";
            this.bigPnlLevel.Size = new System.Drawing.Size(418, 324);
            this.bigPnlLevel.TabIndex = 10;
            this.bigPnlLevel.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.levelSelector);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(0, -5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(421, 165);
            this.panel7.TabIndex = 1;
            // 
            // levelSelector
            // 
            this.levelSelector.FormattingEnabled = true;
            this.levelSelector.Location = new System.Drawing.Point(168, 44);
            this.levelSelector.Name = "levelSelector";
            this.levelSelector.Size = new System.Drawing.Size(200, 24);
            this.levelSelector.TabIndex = 1;
            this.levelSelector.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.levelSelector_DrawItem);
            this.levelSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.levelSelector.VisibleChanged += new System.EventHandler(this.levelSelector_VisibleChanged);
            this.levelSelector.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.levelSelector_Validating);
            this.levelSelector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.levelSelector_MouseClick);
            this.levelSelector.Validating += new System.ComponentModel.CancelEventHandler(this.levelSelector_Validating);
            this.levelSelector.Validated += new System.EventHandler(this.levelSelector_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 50);
            this.label8.TabIndex = 0;
            this.label8.Text = "Niveau :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pnlValidateLevel
            // 
            this.pnlValidateLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(173)))));
            this.pnlValidateLevel.Controls.Add(this.label9);
            this.pnlValidateLevel.Location = new System.Drawing.Point(0, 166);
            this.pnlValidateLevel.Name = "pnlValidateLevel";
            this.pnlValidateLevel.Size = new System.Drawing.Size(247, 158);
            this.pnlValidateLevel.TabIndex = 3;
            this.pnlValidateLevel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlValidateLevel_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 50);
            this.label9.TabIndex = 0;
            this.label9.Text = "Jouer";
            this.label9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlValidateLevel_MouseClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(249, 167);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(169, 157);
            this.panel9.TabIndex = 4;
            this.panel9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlQuite_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 50);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quitter";
            this.label10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlQuite_MouseClick);
            // 
            // pnlAb
            // 
            this.pnlAb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.pnlAb.Controls.Add(this.label16);
            this.pnlAb.Controls.Add(this.label15);
            this.pnlAb.Controls.Add(this.label14);
            this.pnlAb.Controls.Add(this.label13);
            this.pnlAb.Controls.Add(this.label11);
            this.pnlAb.Controls.Add(this.label12);
            this.pnlAb.Location = new System.Drawing.Point(88, 159);
            this.pnlAb.Name = "pnlAb";
            this.pnlAb.Size = new System.Drawing.Size(415, 324);
            this.pnlAb.TabIndex = 11;
            this.pnlAb.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(171, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 23);
            this.label16.TabIndex = 6;
            this.label16.Text = "- Stéphane Eintrazi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(171, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 23);
            this.label15.TabIndex = 5;
            this.label15.Text = "- Hugo Dufossez";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(171, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "- Mehdi Bouchagour";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(171, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "- Sylvain Bardin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cette application est proposée par ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(27, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(341, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Bienvenue sur Casse Brique 8.1 !";
            // 
            // NewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(582, 560);
            this.ControlBox = false;
            this.Controls.Add(this.bigPnlLevel);
            this.Controls.Add(this.bigPnlOnePlayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRightArrow);
            this.Controls.Add(this.pnlAb);
            this.Controls.Add(this.pnlLeftArrow);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "NewHome";
            this.Text = "Casse Brique 8.1";
            this.Load += new System.EventHandler(this.NewHome_Load);
            this.pnlOnePlayer.ResumeLayout(false);
            this.pnlOnePlayer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl2Players.ResumeLayout(false);
            this.pnl2Players.PerformLayout();
            this.pnlQuite.ResumeLayout(false);
            this.pnlQuite.PerformLayout();
            this.pnlAbou.ResumeLayout(false);
            this.pnlAbou.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlValidatePlayer.ResumeLayout(false);
            this.pnlValidatePlayer.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.bigPnlOnePlayer.ResumeLayout(false);
            this.bigPnlLevel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlValidateLevel.ResumeLayout(false);
            this.pnlValidateLevel.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pnlAb.ResumeLayout(false);
            this.pnlAb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOnePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl2Players;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlQuite;
        private System.Windows.Forms.Panel pnlAbou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pnlAbout;
        private System.Windows.Forms.Panel pnlLeftArrow;
        private System.Windows.Forms.Panel pnlRightArrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlValidatePlayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel bigPnlOnePlayer;
        private System.Windows.Forms.Panel bigPnlLevel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlValidateLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox levelSelector;
        private System.Windows.Forms.Panel pnlAb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;

    }
}