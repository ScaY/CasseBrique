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
    public partial class NewHome : Form
    {
        public NewHome()
        {
            InitializeComponent();
        }

        private List<Player> players = new List<Player>();
        private List<Level> levelsStandard = new List<Level>();
        private List<Level> levelsCustom = new List<Level>();
        private List<Level> levelsAllTypes = new List<Level>();

        private Level selectedLevel = null;
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
            this.panel1.Hide();
            this.isMultiPlayer = false;
            this.label5.Text = "Joueur : ";
            this.pnlLeftArrow.Show();

            this.bigPnlOnePlayer.BringToFront();
            this.bigPnlOnePlayer.Show();

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
            this.pnlLeftArrow.Show();
            this.panel1.Hide();
            this.pnlAb.Show();
        }

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedLevel = this.levelsAllTypes.ElementAt(this.levelSelector.SelectedIndex);
        }

        private void pnlValidateOnePlayer_MouseClick(object sender, MouseEventArgs e)
        {

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
            if (this.levelsStandard != null)
            {
                
                this.bigPnlLevel.Hide();
                this.panel8.Show();
                this.panel10.Show();
                if (this.players.ElementAt(0) != null)
                {
                    this.players.ElementAt(0).ControlGame = NameControlerBar.Mouse;

                }
                if (this.players.Count >1)
                {
                    this.players.ElementAt(1).ControlGame = NameControlerBar.KeyboardKM;

                }


            }
            else
            {
                MessageBox.Show("Veuillez choisir un niveau !");
            }


        }

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void levelSelector_Validating(object sender, CancelEventArgs e)
        {
        }
        private void levelSelector_Validating(object sender, EventArgs e)
        {
            
        }

        private void levelSelector_Validating(object sender, ControlEventArgs e)
        {
           
        }

        private void levelSelector_DrawItem(object sender, DrawItemEventArgs e)
        {
           

        }

        private void levelSelector_MouseClick(object sender, MouseEventArgs e)
        {
         


        }

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

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            LevelCreation lc = new LevelCreation();
            lc.Show();
        }

        private void label17_MouseMove(object sender, MouseEventArgs e)
        {

        }

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.players.ElementAt(0).ControlGame = NameControlerBar.Mouse;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.players.ElementAt(0).ControlGame = NameControlerBar.KeyboardQD;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.players.ElementAt(1).ControlGame = NameControlerBar.KeyboardKM;
            }

        }

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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label18_Paint(object sender, PaintEventArgs e)
        {
            if (this.players.ElementAt(1) != null)
            {
                
                this.player2Config.Show();
                this.label18.Text = this.players.ElementAt(1).Name;
            }


        }

        private void pnlValidateLevel_Paint(object sender, PaintEventArgs e)
        {

        }

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

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(runGame));
            oThread.Start();
            this.Close();
        }

    }
}
