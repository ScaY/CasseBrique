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
        public EndGame()
        {
            
            InitializeComponent();
        }

        private void playAgain_click(object sender, EventArgs e)
        {
            NewHome m = new NewHome();
            Application.Run(m);
            this.Close();
        }

        private void exit_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
