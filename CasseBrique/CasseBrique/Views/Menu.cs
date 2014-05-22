using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasseBrique.Views
{
    
    public class Menu
    {
        public static const float Default_Frame_Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width*3/4;
        public static const float Default_Frame_Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height*3/4;

        public static const Point Default_Frame_Position = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height/2);



        public Form MenuFrame { get; set; }

        public float FrameWidth { get; set; }
        public float FrameHeight { get; set;}
        public Point FramePosition { get; set; }


        public float PanelWidth { get; set; }
        public float PanelHeight { get; set; }
        public Point PanelPosition { get; set; }



        public Menu(){
            FrameWidth = Default_Frame_Width;
            FrameHeight = Default_Frame_Height;
            FramePosition = Default_Frame_Position;

            Home h = new Home();
            
            Application.Run(h);
            
        }


    }
}
