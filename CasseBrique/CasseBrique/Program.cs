#region Using Statements
using Breakout.Model;
using Breakout.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
#endregion

namespace Breakout
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                //Home m = new Home();
                //Application.Run(m);
                using (var game = new GameXNA(new Player("toto")))
                game.Run();
            
        }
    }
#endif
}
