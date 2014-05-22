#region Using Statements
using Breakout.Views;
using CasseBrique.Views;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Menu m = new Menu();
                //using (var game = new GameXNA())
                    //game.Run();
            
        }
    }
#endif
}
