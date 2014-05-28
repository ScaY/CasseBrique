namespace CasseBrique.Views
{
    partial class LevelCreation
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
            this.pnl1Titre = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnl2Outils = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.pnlValidate = new System.Windows.Forms.Panel();
            this.lblValidate = new System.Windows.Forms.Label();
            this.pnlNoTool = new System.Windows.Forms.Panel();
            this.lblDelete = new System.Windows.Forms.Label();
            this.pnl4Player = new System.Windows.Forms.Panel();
            this.lblBricks = new System.Windows.Forms.Label();
            this.pnl3Map = new System.Windows.Forms.Panel();
            this.pnlNbBricks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.pnl1Titre.SuspendLayout();
            this.pnl2Outils.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlValidate.SuspendLayout();
            this.pnlNoTool.SuspendLayout();
            this.pnl4Player.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1Titre
            // 
            this.pnl1Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnl1Titre.Controls.Add(this.lbl1);
            this.pnl1Titre.Location = new System.Drawing.Point(-2, 0);
            this.pnl1Titre.Margin = new System.Windows.Forms.Padding(2);
            this.pnl1Titre.Name = "pnl1Titre";
            this.pnl1Titre.Size = new System.Drawing.Size(847, 81);
            this.pnl1Titre.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(272, 9);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(286, 65);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Casse Brique";
            // 
            // pnl2Outils
            // 
            this.pnl2Outils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnl2Outils.Controls.Add(this.panel3);
            this.pnl2Outils.Controls.Add(this.txtLevelName);
            this.pnl2Outils.Controls.Add(this.pnlValidate);
            this.pnl2Outils.Controls.Add(this.pnlNoTool);
            this.pnl2Outils.Controls.Add(this.pnl4Player);
            this.pnl2Outils.Location = new System.Drawing.Point(-2, 85);
            this.pnl2Outils.Margin = new System.Windows.Forms.Padding(2);
            this.pnl2Outils.Name = "pnl2Outils";
            this.pnl2Outils.Size = new System.Drawing.Size(171, 458);
            this.pnl2Outils.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblBonus);
            this.panel3.Location = new System.Drawing.Point(13, 82);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 57);
            this.panel3.TabIndex = 4;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.lblBonus.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.ForeColor = System.Drawing.Color.White;
            this.lblBonus.Location = new System.Drawing.Point(23, 8);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(95, 41);
            this.lblBonus.TabIndex = 9;
            this.lblBonus.Text = "Bonus";
            this.lblBonus.Click += new System.EventHandler(this.lblBonus_Click);
            // 
            // txtLevelName
            // 
            this.txtLevelName.Location = new System.Drawing.Point(13, 275);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.Size = new System.Drawing.Size(144, 20);
            this.txtLevelName.TabIndex = 6;
            this.txtLevelName.Text = "Nom du niveau ex : niv1";
            this.txtLevelName.TextChanged += new System.EventHandler(this.txtLevelName_TextChanged);
            // 
            // pnlValidate
            // 
            this.pnlValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(1)))));
            this.pnlValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlValidate.Controls.Add(this.lblValidate);
            this.pnlValidate.Location = new System.Drawing.Point(13, 376);
            this.pnlValidate.Margin = new System.Windows.Forms.Padding(2);
            this.pnlValidate.Name = "pnlValidate";
            this.pnlValidate.Size = new System.Drawing.Size(145, 64);
            this.pnlValidate.TabIndex = 5;
            this.pnlValidate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlValidate_MouseClick);
            // 
            // lblValidate
            // 
            this.lblValidate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValidate.AutoSize = true;
            this.lblValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(1)))));
            this.lblValidate.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidate.ForeColor = System.Drawing.Color.White;
            this.lblValidate.Location = new System.Drawing.Point(2, 12);
            this.lblValidate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(143, 41);
            this.lblValidate.TabIndex = 8;
            this.lblValidate.Text = "Validation";
            this.lblValidate.Click += new System.EventHandler(this.lblValidate_Click);
            // 
            // pnlNoTool
            // 
            this.pnlNoTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.pnlNoTool.Controls.Add(this.lblDelete);
            this.pnlNoTool.Location = new System.Drawing.Point(13, 159);
            this.pnlNoTool.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNoTool.Name = "pnlNoTool";
            this.pnlNoTool.Size = new System.Drawing.Size(145, 60);
            this.pnlNoTool.TabIndex = 3;
            this.pnlNoTool.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlNoTool_MouseClick);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.lblDelete.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.White;
            this.lblDelete.Location = new System.Drawing.Point(23, 10);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(100, 41);
            this.lblDelete.TabIndex = 10;
            this.lblDelete.Text = "Suppr.";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // pnl4Player
            // 
            this.pnl4Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.pnl4Player.Controls.Add(this.lblBricks);
            this.pnl4Player.Location = new System.Drawing.Point(13, 2);
            this.pnl4Player.Margin = new System.Windows.Forms.Padding(2);
            this.pnl4Player.Name = "pnl4Player";
            this.pnl4Player.Size = new System.Drawing.Size(145, 57);
            this.pnl4Player.TabIndex = 2;
            this.pnl4Player.Click += new System.EventHandler(this.pnl4Player_Click);
            // 
            // lblBricks
            // 
            this.lblBricks.AutoSize = true;
            this.lblBricks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.lblBricks.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBricks.ForeColor = System.Drawing.Color.White;
            this.lblBricks.Location = new System.Drawing.Point(23, 7);
            this.lblBricks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBricks.Name = "lblBricks";
            this.lblBricks.Size = new System.Drawing.Size(98, 41);
            this.lblBricks.TabIndex = 8;
            this.lblBricks.Text = "Brique";
            this.lblBricks.Click += new System.EventHandler(this.lblBricks_Click);
            // 
            // pnl3Map
            // 
            this.pnl3Map.BackColor = System.Drawing.Color.White;
            this.pnl3Map.Location = new System.Drawing.Point(173, 138);
            this.pnl3Map.Margin = new System.Windows.Forms.Padding(2);
            this.pnl3Map.Name = "pnl3Map";
            this.pnl3Map.Size = new System.Drawing.Size(670, 340);
            this.pnl3Map.TabIndex = 5;
            this.pnl3Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl3Map_MouseMove);
            // 
            // pnlNbBricks
            // 
            this.pnlNbBricks.AutoSize = true;
            this.pnlNbBricks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.pnlNbBricks.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNbBricks.ForeColor = System.Drawing.Color.White;
            this.pnlNbBricks.Location = new System.Drawing.Point(81, 3);
            this.pnlNbBricks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnlNbBricks.Name = "pnlNbBricks";
            this.pnlNbBricks.Size = new System.Drawing.Size(408, 41);
            this.pnlNbBricks.TabIndex = 2;
            this.pnlNbBricks.Text = "Nombre de briques restantes : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.pnlNbBricks);
            this.panel2.Location = new System.Drawing.Point(173, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 53);
            this.panel2.TabIndex = 3;
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.Location = new System.Drawing.Point(174, 483);
            this.txtErrorMessage.Multiline = true;
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.ReadOnly = true;
            this.txtErrorMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorMessage.Size = new System.Drawing.Size(669, 48);
            this.txtErrorMessage.TabIndex = 6;
            this.txtErrorMessage.WordWrap = false;
            // 
            // LevelCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(845, 543);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl3Map);
            this.Controls.Add(this.pnl2Outils);
            this.Controls.Add(this.pnl1Titre);
            this.Name = "LevelCreation";
            this.Text = "testCreationLevel";
            this.Load += new System.EventHandler(this.testCreationLevel_Load);
            this.pnl1Titre.ResumeLayout(false);
            this.pnl1Titre.PerformLayout();
            this.pnl2Outils.ResumeLayout(false);
            this.pnl2Outils.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlValidate.ResumeLayout(false);
            this.pnlValidate.PerformLayout();
            this.pnlNoTool.ResumeLayout(false);
            this.pnlNoTool.PerformLayout();
            this.pnl4Player.ResumeLayout(false);
            this.pnl4Player.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1Titre;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnl2Outils;
        private System.Windows.Forms.Panel pnl3Map;
        private System.Windows.Forms.Panel pnl4Player;
        private System.Windows.Forms.Panel pnlNoTool;
        private System.Windows.Forms.Panel pnlValidate;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Label pnlNbBricks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBricks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblValidate;
        private System.Windows.Forms.TextBox txtErrorMessage;
    }
}