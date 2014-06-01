using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents the actions done by the form displayed at the end of a game.
    /// </summary>
    public partial class EndGame : Form
    {
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public BreakoutModel Model { get; set; }

        /// <summary>
        /// Gets or sets the player names.
        /// </summary>
        /// <value>
        /// The player names.
        /// </value>
        public List<Label> playerNames { get; set; }

        /// <summary>
        /// The game (XNA object).
        /// </summary>
        private GameXNA game;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndGame"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="_game">The game.</param>
        /// <param name="gameTime">The game time.</param>
        public EndGame(BreakoutModel model, GameXNA _game, GameTime gameTime)
        {
            InitializeComponent();

            this.Model = model;
            this.game = _game;
            //this function display a new window to inform the user if he has won or not
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

        /// <summary>
        /// Handles the click event of the playAgain control. Starts a new game with the same players and level.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void playAgain_click(object sender, EventArgs e)
        {
            game.Reset(this.Model.Players, this.Model.Level);
            this.Close();
        }

        /// <summary>
        /// Handles the click event of the menu control. Opens the home menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void menu_click(object sender, EventArgs e)
        {
            NewHome m = new NewHome(this.game);
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
    }
}
