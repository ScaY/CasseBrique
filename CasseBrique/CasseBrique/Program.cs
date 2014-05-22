#region Using Statements
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
            //Home h = new Home();
            //Application.Run(h);
                using (var game = new GameXNA())
                    game.Run();
            
        }
    }
#endif
}
