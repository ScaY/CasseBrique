using Breakout;
using Breakout.Model;
using CasseBrique.Model;
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

        public static Point Default_Frame_Position = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2);
        public static int Default_Frame_Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width * 3 / 4;
        public static int Default_Frame_Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height * 3 / 4;



        
        public List<Player> Players { get; set; }
        public Level LevelChoosed { get; set; }

        public Home()
        {
            InitializeComponent();


            Players = new List<Player>();



            this.panel1.Show();
            this.panel2.Hide();
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
            Console.WriteLine("salut");
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
                Players.Add( new Player(this.textBox1.Text));
            }
            
            foreach (Control item in panel3.Controls)
            {
                if (item == this.comboBox1){
                
                    var cb =(ComboBox) item;
                    List<Level> Levels = Level.loadAllDefault();
                    foreach (Level level in Levels)
                    {
                        cb.Items.Add(level.LevelName);
                    }
                }
                else if (item == this.comboBox2)
                {
                    var cb = (ComboBox)item;
                    List<Level> Levels = CustomLevel.loadAllCustom();
                    foreach (Level level in Levels)
                    {
                        cb.Items.Add(level.LevelName);
                    }
                }

            }
            this.panel2.Hide();
            this.panel3.Show();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            using (var game = new GameXNA(this.Players, this))
                game.Run();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
