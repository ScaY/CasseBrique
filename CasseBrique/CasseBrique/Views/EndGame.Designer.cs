namespace Breakout.Views
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.pnlRightArrow = new System.Windows.Forms.Panel();
            this.pnlLeftArrow = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlValidateLevel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_players = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_2p = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlValidateLevel.SuspendLayout();
            this.pnl_players.SuspendLayout();
            this.pnl_2p.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRightArrow
            // 
            this.pnlRightArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRightArrow.BackgroundImage")));
            this.pnlRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlRightArrow.Location = new System.Drawing.Point(380, 128);
            this.pnlRightArrow.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRightArrow.Name = "pnlRightArrow";
            this.pnlRightArrow.Size = new System.Drawing.Size(48, 45);
            this.pnlRightArrow.TabIndex = 14;
            this.pnlRightArrow.Visible = false;
            // 
            // pnlLeftArrow
            // 
            this.pnlLeftArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLeftArrow.BackgroundImage")));
            this.pnlLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLeftArrow.Location = new System.Drawing.Point(9, 128);
            this.pnlLeftArrow.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeftArrow.Name = "pnlLeftArrow";
            this.pnlLeftArrow.Size = new System.Drawing.Size(48, 45);
            this.pnlLeftArrow.TabIndex = 13;
            this.pnlLeftArrow.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 81);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casse Brique";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_players);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(62, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 316);
            this.panel1.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(184, 187);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(127, 128);
            this.panel9.TabIndex = 5;
            this.panel9.Click += new System.EventHandler(this.menu_click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 41);
            this.label10.TabIndex = 1;
            this.label10.Text = "Menu";
            this.label10.Click += new System.EventHandler(this.menu_click);
            // 
            // pnlValidateLevel
            // 
            this.pnlValidateLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(173)))));
            this.pnlValidateLevel.Controls.Add(this.label9);
            this.pnlValidateLevel.Location = new System.Drawing.Point(62, 314);
            this.pnlValidateLevel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlValidateLevel.Name = "pnlValidateLevel";
            this.pnlValidateLevel.Size = new System.Drawing.Size(180, 128);
            this.pnlValidateLevel.TabIndex = 6;
            this.pnlValidateLevel.Click += new System.EventHandler(this.playAgain_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 41);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rejouer";
            this.label9.Click += new System.EventHandler(this.playAgain_click);
            // 
            // pnl_players
            // 
            this.pnl_players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnl_players.Controls.Add(this.pnl_2p);
            this.pnl_players.Controls.Add(this.lbl_name);
            this.pnl_players.Location = new System.Drawing.Point(-2, 2);
            this.pnl_players.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_players.Name = "pnl_players";
            this.pnl_players.Size = new System.Drawing.Size(316, 179);
            this.pnl_players.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(5, 83);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 25);
            this.lbl_name.TabIndex = 0;
            // 
            // pnl_2p
            // 
            this.pnl_2p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnl_2p.Controls.Add(this.lbl_name2);
            this.pnl_2p.Controls.Add(this.lbl_name1);
            this.pnl_2p.Controls.Add(this.label2);
            this.pnl_2p.Location = new System.Drawing.Point(2, 1);
            this.pnl_2p.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_2p.Name = "pnl_2p";
            this.pnl_2p.Size = new System.Drawing.Size(316, 179);
            this.pnl_2p.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 0;
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name1.Location = new System.Drawing.Point(2, 40);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(0, 25);
            this.lbl_name1.TabIndex = 1;
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name2.Location = new System.Drawing.Point(2, 99);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(0, 25);
            this.lbl_name2.TabIndex = 2;
            this.lbl_name2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "principal";
            this.label3.Click += new System.EventHandler(this.menu_click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(438, 456);
            this.Controls.Add(this.pnlValidateLevel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRightArrow);
            this.Controls.Add(this.pnlLeftArrow);
            this.Controls.Add(this.panel2);
            this.Name = "EndGame";
            this.Text = "Fin du jeu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pnlValidateLevel.ResumeLayout(false);
            this.pnlValidateLevel.PerformLayout();
            this.pnl_players.ResumeLayout(false);
            this.pnl_players.PerformLayout();
            this.pnl_2p.ResumeLayout(false);
            this.pnl_2p.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRightArrow;
        private System.Windows.Forms.Panel pnlLeftArrow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlValidateLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_players;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_2p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name2;
        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Label label3;

    }
}