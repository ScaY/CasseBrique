using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Breakout.Views
{
    public partial class EndGame : Form
    {
        public BreakoutModel Model { get; set; }
        public List<Label> playerNames { get; set; }
        private Game game;

        public EndGame(BreakoutModel model, Game _game, GameTime gameTime)
        {
            InitializeComponent();

            this.Model = model;
            this.game = _game;

            int nbBricksTotal = model.BrickZone.NbBrickCol * model.BrickZone.NbBrickRow;

            StringBuilder stringBuilder = new StringBuilder();
            if (gameTime.TotalGameTime.Minutes < 10)
            {
                stringBuilder.Append("0");
            }
            stringBuilder.Append(gameTime.TotalGameTime.Minutes.ToString());
            stringBuilder.Append(":");
            if (gameTime.TotalGameTime.Seconds < 10)
            {
                stringBuilder.Append("0");
            }
            stringBuilder.Append(gameTime.TotalGameTime.Seconds.ToString());

            if (this.Model.IsGameWon())
            {
                this.lbl_result1P.Text = "Félicitations, vous avez gagné.";
            }
            else if (this.Model.IsGameLost())
            {
                this.lbl_result1P.Text = "Dommage, vous avez perdu.";
            }

            this.lbl_duree1P.Text = stringBuilder.ToString();

            this.lbl_nameP1.Text = model.Players[0].Name;

            if (model.Players.Count == 2)
            {
                this.lbl_nameP2.Text = model.Players[1].Name;
            }
            else
            {
                this.lbl_nameP2.Text = "";
                this.label2.Text = "Joueur :";
            }
        }

        private void runGame()
        {
            using (var game = new GameXNA(Model.Players, Model.Level))
                game.Run();
        }

        private void playAgain_click(object sender, EventArgs e)
        {
            /*Thread oThread = new Thread(new ThreadStart(runGame));
            oThread.Start();*/
            this.Hide();
            runGame();;
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
