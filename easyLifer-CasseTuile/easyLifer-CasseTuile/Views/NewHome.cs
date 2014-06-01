using Breakout.Model;
using CasseBrique.Controler;
using CasseBrique.Model;
using CasseBrique.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Breakout
{
    /// <summary>
    /// This is a class that contains all the handlers for the event of the form NewHome.
    /// </summary>
    public partial class NewHome : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewHome"/> class.
        /// </summary>
        public NewHome() : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewHome"/> class.
        /// </summary>
        /// <param name="_game">The game.</param>
        public NewHome(GameXNA _game)
        {
            this.game = _game;
            InitializeComponent();
        }

        /// <summary>
        /// A list of players, used to store the data entered about the players
        /// </summary>
        private List<Player> players = new List<Player>();


        /// <summary>
        /// A list of standard levels
        /// </summary>
        private List<Level> levelsStandard = new List<Level>();

        /// <summary>
        /// A list of custom levels
        /// </summary>
        private List<Level> levelsCustom = new List<Level>();

        /// <summary>
        /// A list of levels of all types
        /// </summary>
        private List<Level> levelsAllTypes = new List<Level>();

        /// <summary>
        /// The selected level
        /// </summary>
        private Level selectedLevel = null;

        /// <summary>
        /// True if multiplayer, false otherwise
        /// </summary>
        private bool isMultiPlayer = false;

        /// <summary>
        /// The game
        /// </summary>
        private GameXNA game;

        /// <summary>
        /// Handles the MouseClick event of the pnlOnePlayer control. Hide the current panel and adds the panel to select the name of the player.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void pnlOnePlayer_MouseClick(object sender, MouseEventArgs e)
        {
            this.panel1.Hide();
            this.isMultiPlayer = false;
            this.label5.Text = "Joueur : ";
            this.pnlLeftArrow.Show();

            this.bigPnlOnePlayer.BringToFront();
            this.bigPnlOnePlayer.Show();

        }

        /// <summary>
        /// Handles the Click event of the pnlQuite control. Exits the game.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pnlQuite_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                game.Exit();
            }

            this.Close();
        }

        /// <summary>
        /// Handles the MouseClick event of the pnlAbou control. Hides the current panel and show the about panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void pnlAbou_MouseClick(object sender, MouseEventArgs e)
        {
            this.pnlLeftArrow.Show();
            this.panel1.Hide();
            this.pnlAb.Show();
        }

        /// <summary>
        /// Handles the MouseClick event of the pnl2Players control. Hides the current panel and shows the panel to enter the name of the first player.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void pnl2Players_MouseClick(object sender, MouseEventArgs e)
        {
            this.isMultiPlayer = true;
            this.players = new List<Player>();
            if (this.players.Count <= 1)
            {
                this.panel1.Hide();
                this.pnlLeftArrow.Show();

                this.bigPnlOnePlayer.Show();
                
                this.label5.Text = "Joueur  "+ (this.players.Count + 1)+" : ";
                this.textBox1.Text = "";

            }
            else
            {

                this.panel1.Hide();
                this.bigPnlLevel.Show();

            }
        }

        /// <summary>
        /// Handles the Click event of the pnlOnePlayer control. Hides the current panel and displays the panel to let the player enter his name.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pnlOnePlayer_Click(object sender, EventArgs e)
        {
            this.players = new List<Player>();

            this.panel1.Hide();
            this.isMultiPlayer = false;

            this.pnlLeftArrow.Show();
            this.bigPnlOnePlayer.BringToFront();
            this.bigPnlOnePlayer.Show();
            this.textBox1.Text = "";

        }

        /// <summary>
        /// Handles the MouseClick event of the panel5 control. Adds the player to the list, hides the panel and displays the panel to select a level.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.isMultiPlayer)
            {
                if (textBox1.Text != null && textBox1.Text != "" && textBox1.Text.Length > 0)
                {
                    if (this.players.Count <= 1)
                    {
                        this.players.Add(new Player(textBox1.Text));

                    }
                    
                    this.bigPnlOnePlayer.Hide();
                    this.bigPnlLevel.Show();


                }
                else
                {
                    MessageBox.Show("Veuillez spécifier un nom d'utilisateur valide !");
                }

            }
            else
            {
                if (textBox1.Text != null && textBox1.Text != "" && textBox1.Text.Length > 0)
                {
                    this.players.Add(new Player(textBox1.Text));

                }
                else
                {
                    MessageBox.Show("Veuillez spécifier un nom d'utilisateur valide !");

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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox1 control. Changes the selected level with the one selected in the combobox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedLevel = this.levelsAllTypes.ElementAt(this.levelSelector.SelectedIndex);
        }

        /// <summary>
        /// Handles the MouseClick event of the pnlValidateLevel control. Hides the panel and shows the panel to select the controls.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void pnlValidateLevel_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.levelsStandard != null && this.selectedLevel != null)
            {
               
                    this.bigPnlLevel.Hide();
                    this.panel8.Show();
                    this.panel10.Show();
                    if (this.players.ElementAt(0) != null)
                    {
                        this.players.ElementAt(0).ControlGame = NameControlerBar.Mouse;

                    }
                    if (this.players.Count > 1)
                    {
                        this.players.ElementAt(1).ControlGame = NameControlerBar.KeyboardKM;

                    }
                

            }
            else
            {
                MessageBox.Show("Veuillez choisir un niveau !");
            }


        }

        /// <summary>
        /// Handles the MouseClick event of the pnlLeftArrow control. Hides the current panel and shows the previous one.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void pnlLeftArrow_MouseClick(object sender, MouseEventArgs e)
        {
            this.bigPnlLevel.Hide();
            this.bigPnlOnePlayer.Hide();
            this.pnlAb.Hide();
            this.panel8.Hide();
            this.panel10.Hide();

            this.panel1.Show();
            this.pnlLeftArrow.Hide();
        }

        /// <summary>
        /// Handles the VisibleChanged event of the levelSelector control. Displays all the levels in the combobox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void levelSelector_VisibleChanged(object sender, EventArgs e)
        {
            this.levelsStandard = Level.loadAllDefault();
            this.levelsAllTypes = Level.loadAllDefault();
            this.levelsCustom = CustomLevel.loadAllCustom();
            for (int i = 0; i < this.levelsCustom.Count; i++)
            {
                this.levelsAllTypes.Add(this.levelsCustom.ElementAt(i));
            }
                this.levelSelector.Items.Clear();

            for (int i = 0; i < this.levelsAllTypes.Count; i++)
            {
                if (i >= this.levelsStandard.Count)
                {
                    this.levelSelector.Items.Add(this.levelsAllTypes.ElementAt(i).LevelName+" (Niveau personnalisé)");


                }
                else
                {
                    this.levelSelector.Items.Add(this.levelsAllTypes.ElementAt(i).LevelName + " (Niveau standard)");

                }
            }

        }

        /// <summary>
        /// Handles the MouseClick event of the panel3 control. Displays the level creation form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            LevelCreation lc = new LevelCreation();
            lc.Show();
        }

        /// <summary>
        /// Handles the 1 event of the panel5_MouseClick control. Adds all the levels in the combo box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void panel5_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.levelsStandard = Level.loadAllDefault();
            this.levelsAllTypes = Level.loadAllDefault();
            this.levelsCustom = CustomLevel.loadAllCustom();
            for (int i = 0; i < this.levelsCustom.Count; i++)
            {
                this.levelsAllTypes.Add(this.levelsCustom.ElementAt(i));
            }
            this.levelSelector.Items.Clear();

            for (int i = 0; i < this.levelsAllTypes.Count; i++)
            {
                if (i >= this.levelsStandard.Count)
                {
                    this.levelSelector.Items.Add(this.levelsAllTypes.ElementAt(i).LevelName + " (Niveau personnalisé)");


                }
                else
                {
                    this.levelSelector.Items.Add(this.levelsAllTypes.ElementAt(i).LevelName + " (Niveau standard)");

                }
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the radioButton1 control. Changes the selected controls to the one corresponding to the radio button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.players.ElementAt(0).ControlGame = NameControlerBar.Mouse;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the radioButton2 control. Changes the selected controls to the one corresponding to the radio button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.players.ElementAt(0).ControlGame = NameControlerBar.KeyboardQD;
            }

        }

        /// <summary>
        /// Handles the CheckedChanged event of the radioButton3 control. Changes the selected controls to the one corresponding to the radio button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.players.ElementAt(1).ControlGame = NameControlerBar.KeyboardKM;
            }

        }

        /// <summary>
        /// Handles the Paint event of the lblPlayer1name control. Displays the player names.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void lblPlayer1name_Paint(object sender, PaintEventArgs e)
        {
            if (this.players.Count >= 1)
            {
                this.lblPlayer1name.Text = this.players.ElementAt(0).Name;
            }
            if (this.players.Count > 1)
            {

                this.player2Config.Show();
            }

        }

        /// <summary>
        /// Handles the Paint event of the label18 control. Displays the panel to let the player 2 choose his controls.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void label18_Paint(object sender, PaintEventArgs e)
        {
            if (this.players.ElementAt(1) != null)
            {
                
                this.player2Config.Show();
                this.label18.Text = this.players.ElementAt(1).Name;
            }


        }

        /// <summary>
        /// Runs the game.
        /// </summary>
        private void runGame()
        {
            try
            {
                using (var game = new GameXNA(this.players, this.selectedLevel))
                    game.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Handles the MouseClick event of the panel10 control. Launches the game.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.game != null)
            {
                this.game.Reset(this.players, this.selectedLevel);
            }
            else
            {
                Thread oThread = new Thread(new ThreadStart(runGame));
                oThread.Start();
            }
            this.Close();
        }

    }
}
