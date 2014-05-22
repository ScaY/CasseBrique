using Breakout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasseBrique.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
            this.panel2.Hide();
            this.panel3.Show();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var game = new GameXNA())
                game.Run();

        }
    }
}
