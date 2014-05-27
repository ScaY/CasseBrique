using Breakout;
using Breakout.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Breakout.Views
{
    public partial class Home : Form
    {
        public const int USERS_LIMIT = 2; 
        private List<Player> players;
        public Home()
        {
            this.players = new List<Player>();
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel2.Show();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != null && this.textBox1.Text.Length > 0)
            {

                this.players.Add(new Player(this.textBox1.Text,null,null));
            }
            this.panel2.Hide();
            this.panel3.Show();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var game = new GameXNA(this.players))
            
                game.Run();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel4.Show();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.panel4.Hide();
            this.panel3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.players.Count() < USERS_LIMIT)
            {
                if (this.textBox2.Text != "" && this.textBox2.Text != null)
                {
                    this.msgResponse.Text = "L'utilisateur " + this.textBox2.Text + " a été crée !";

                    this.players.Add(new Player(this.textBox2.Text, null, null));
                    this.textBox2.Text = "";
                }
                else
                {
                    this.msgResponse.Text = "Le champs est vide !";

                }
            }
            else
            {
                this.msgResponse.Text = "L'application ne supporte pas plus de "+USERS_LIMIT+" joueurs.";

            }
        }
    }
}
