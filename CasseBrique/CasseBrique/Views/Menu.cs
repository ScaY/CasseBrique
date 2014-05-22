using Breakout.Views;
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
        public static int Default_Frame_Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width*3/4;
        public static int Default_Frame_Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height*3/4;

        public static  Point Default_Frame_Position = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height/2);



        public Form MenuFrame { get; set; }

        public int FrameWidth { get; set; }
        public int FrameHeight { get; set;}
        public Point FramePosition { get; set; }


        

        


        public Menu(){
            FrameWidth = Default_Frame_Width;
            FrameHeight = Default_Frame_Height;
            FramePosition = Default_Frame_Position;



            Home h = new Home();
            h.SetBounds(FramePosition.X,FramePosition.Y,FrameWidth,FrameHeight);
            System.Windows.Forms.Control.ControlCollection controls = h.Controls;
            
            
            foreach (Control control in controls)
            {
                
                if (control is SplitContainer )
                {
                    SplitContainer split =(SplitContainer) control;
                    Control currentControl = split.Panel2;
                    System.Windows.Forms.Control.ControlCollection panelControls = currentControl.Controls ;
                    foreach (Control panelControl in panelControls)
                    {

                        panelControl.SetBounds(currentControl.Bounds.X / 2, currentControl.Bounds.Y, FrameWidth / 2, FrameHeight / 2);








                        
                    }
                }
            }

            Application.Run(h);
        }


    }



    public class MenuPanel
    {
        public int PanelWidth { get; set; }
        public int PanelHeight { get; set; }
        public Point PanelPosition { get; set; }

        public MenuPanel(Point position, int width, int height)
        {

        }

    }


    public class MenuPanelItem 
    {





    }
    
}
