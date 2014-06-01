#region Using Statements
using System;
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
            Application.Run(new NewHome());
        }
    }
#endif
}
