﻿using Breakout.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Breakout
{
    public partial class NewHome : Form
    {
        public NewHome()
        {
            InitializeComponent();
        }
        private List<Player> players = new List<Player>();
        private bool isMultiPlayer = false;
        private void NewHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pnlLeftArrow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlOnePlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlOnePlayer_MouseHover(object sender, EventArgs e)
        {
            //this.pnlOnePlayer.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pnlQuite_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {

        }

        private void pnl2Players_MouseHover(object sender, EventArgs e)
        {

        }

        private void pnlQuite_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pnlOnePlayer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pnlQuite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlAbou_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pnl2Players_MouseClick(object sender, MouseEventArgs e)
        {
            this.isMultiPlayer = true;

            if (this.players.Count <= 2)
            {
                this.panel1.Hide();
                this.bigPnlOnePlayer.Show();
                
                this.label5.Text = "Joueur  "+ (this.players.Count + 1)+" : ";
            } 
        }

        private void pnlOnePlayer_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.bigPnlOnePlayer.BringToFront();

            this.bigPnlOnePlayer.Show();


        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.players.Add(new Player(textBox1.Text,null,null));
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.isMultiPlayer)
            {
                if (textBox1.Text != null && textBox1.Text != "" && textBox1.Text.Length > 0)
                {
                    this.players.Add(new Player(textBox1.Text));
                    
                    this.bigPnlOnePlayer.Hide();
                    this.bigPnlLevel.Show();


                }

            }
            else
            {
                if (textBox1.Text != null && textBox1.Text != "" && textBox1.Text.Length > 0)
                {
                    this.players.Add(new Player(textBox1.Text));

                }

                if (this.players.Count <= 1 || this.players == null)
                {
                    this.textBox1.Text = "";
                    this.label5.Text = "Joueur  " + (this.players.Count+1) + " : ";
    
                }
                else
                {
                    this.bigPnlOnePlayer.Hide(); 
                    this.bigPnlLevel.Show();

                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlValidateOnePlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.isMultiPlayer == false)
            {
                this.bigPnlOnePlayer.Hide();
                this.bigPnlLevel.Show();
            }
            else
            {
                if (this.players.Count <= 2)
                {
                    this.label5.Text = "Joueur  " + (this.players.Count + 1) + " : ";

                }
                else
                {
                    this.bigPnlOnePlayer.Hide();
                    this.bigPnlLevel.Show();

                }
            }
        }

        private void pnlQuite_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pnlValidateOnePlayer_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pnlValidateLevel_MouseClick(object sender, MouseEventArgs e)
        {
            using (var game = new GameXNA(this.players))

                game.Run();


        }
    }
}