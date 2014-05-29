using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Breakout.Views
{
    public partial class EndGame : Form
    {
        public BreakoutModel Model { get; set; }
        public List<Label> playerNames { get; set; }
        private Game game;

        public EndGame(BreakoutModel model, Game _game)
        {
            InitializeComponent();

            this.Model = model;
            this.game = _game;

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

        private void runGame()
        {
            using (var game = new GameXNA(Model.Players, Model.Level))
                game.Run();
        }

        private void playAgain_click(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(runGame));
            oThread.Start();
            this.Close();
        }

        private void menu_click(object sender, EventArgs e)
        {
            NewHome m = new NewHome();
            this.Hide();
            m.ShowDialog();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            this.game.Exit();
        }
    }
}
