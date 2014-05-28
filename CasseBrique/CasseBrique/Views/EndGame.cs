using Breakout.Model;
using Microsoft.Xna.Framework;
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
    public partial class EndGame : Form
    {
        public List<Label> playerNames { get; set; }

        public EndGame(BreakoutModel model)
        {
            InitializeComponent();

            if (model.Players.Count == 1)
            {
                this.lbl_name.Text = model.Players[0].Name;
                this.pnl_players.Show();
                this.pnl_2p.Hide();
            }
            else if (model.Players.Count == 2)
            {
                this.lbl_name1.Text = model.Players[0].Name;
                this.lbl_name2.Text = model.Players[1].Name;
                this.pnl_players.Hide();
                this.pnl_2p.Show();
            }
        }

        private void playAgain_click(object sender, EventArgs e)
        {
            NewHome m = new NewHome();
            m.ShowDialog();
            this.Close();
        }

        private void exit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
