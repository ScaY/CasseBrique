using Breakout.Bonus;
using Breakout.Model;
using CasseBrique.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasseBrique.Views
{
    public partial class LevelCreation : Form
    {
        public int BrickHeight { get; set; }
        public int BrickWidth { get; set; }
        public bool IsAddingBricks { get; set; }
        public int NbMaxBricks { get; set; }
        public bool NoToolSelected { get; set; }
        public bool AddBonusSelected { get; set; }
        string LevelName { get; set; }

        public TextBox ErrorConsole { get; set; }

        public Control currentBrick { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LevelCreation"/> class.
        /// </summary>
        public LevelCreation()
        {

            AddBonusSelected = false;
            NoToolSelected = true;
            NbMaxBricks = 100;//limit the number of bricks allowed.


            IsAddingBricks = false;
            InitializeComponent();
            BrickHeight = pnl3Map.Height / 10;
            BrickWidth = pnl3Map.Width / 10;
            ErrorConsole = this.txtErrorMessage;
            this.pnlNbBricks.Text = String.Format("Nombre de Briques restantes : {0}", NbMaxBricks);
        }
        /// <summary>
        /// Decimals the nb of bricks.
        /// </summary>
        public void decNbBricks()
        {
            NbMaxBricks--;
            this.pnlNbBricks.Text = String.Format("Nombre de Briques restantes : {0}", NbMaxBricks);
        }
        /// <summary>
        /// Incs the nb of bricks.
        /// </summary>
        public void incNbBricks()
        {
            NbMaxBricks++;
            this.pnlNbBricks.Text = String.Format("Nombre de Briques restantes : {0}", NbMaxBricks);
        }
        /// <summary>
        /// Validates the form.
        /// </summary>
        public void validate()
        {

            CustomLevel lvl = new CustomLevel(LevelName, null);

            if (!(lvl.LevelName == null))
            {
                //checks if the level is already existing
                if (!File.Exists(lvl.Path))
                {
                    bool hasBricks = false;
                    //Creation of the bricks
                    Brick[,] bricks = new Brick[pnl3Map.Width / BrickWidth, pnl3Map.Height / BrickHeight];

                    foreach (Control item in pnl3Map.Controls)
                    {
                        StaticBrick currentB = item as StaticBrick;
                        if (currentB != null)
                        {
                            //each brick get a position depending of the row and the col
                            hasBricks = true;
                            int i = (int)Math.Floor((double)currentB.Bounds.X / BrickWidth);
                            int j = (int)Math.Floor((double)currentB.Bounds.Y / BrickHeight);
                            var brick = new Brick();
                            brick.Position = new Microsoft.Xna.Framework.Vector2(j, i);
                            brick.XBrick = i;
                            brick.YBrick = j;
                            brick.Life = 3;
                            if (currentB.bonus != null)
                            {
                                brick.Bonus = currentB.bonus;
                                brick.Bonus.Speed = 1f;
                                brick.Bonus.Position = brick.Position;
                                brick.Bonus.Deplacement = Microsoft.Xna.Framework.Vector2.Normalize(Microsoft.Xna.Framework.Vector2.UnitY);
                                brick.Bonus.Size = new Breakout.Model.Size(32, 32);
                            }



                            bricks[j, i] = brick;

                        }

                    }



                    lvl.Map = new BrickZone(pnl3Map.Width / BrickWidth, pnl3Map.Height / BrickHeight, 0, 0, bricks);

                    if (hasBricks)
                    {
                        lvl.write();
                        this.Close();
                    }
                    else
                    {
                        ErrorConsole.AppendText("Aucune brique ajoutée.\r\n");
                    }

                }
                else
                {
                    ErrorConsole.AppendText("Nom de niveau déjà pris.\r\n");

                }
            }
            else
            {
                ErrorConsole.AppendText("Aucun nom de niveau renseigné.\r\n");
            }

        }

        /// <summary>
        /// Adds a brick in the good area
        /// </summary>
        public void addBrickToolAction()
        {
            NoToolSelected = false;
            IsAddingBricks = true;

            currentBrick = new MovableBrick(this, BrickWidth, BrickHeight);
            currentBrick.BackColor = Color.FromArgb(51, 51, 51);




            pnl3Map.Controls.Add(currentBrick);
            pnl3Map.Controls.SetChildIndex(currentBrick, 0);
        }
        public void addBonusToolAction()
        {
            AddBonusSelected = true;


        }

        /// <summary>
        /// Disables all tools.
        /// </summary>
        public void disableAllTools()
        {
            pnl3Map.Controls.Remove(currentBrick);
            AddBonusSelected = false;
            NoToolSelected = false;
            IsAddingBricks = false;
        }
        /// <summary>
        /// Deletes the brick tool action.
        /// </summary>
        public void deleteBrickToolAction()
        {

            IsAddingBricks = false;
            NoToolSelected = true;
        }
        private void testCreationLevel_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the pnl4Player control.
        /// Allows the user to add new bricks with the correct tool
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pnl4Player_Click(object sender, EventArgs e)
        {
            disableAllTools();

            addBrickToolAction();
        }

        private void pnl3Map_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsAddingBricks)
            {
                MovableBrick c = null;
                foreach (Control control in pnl3Map.Controls)
                {
                    if (control is MovableBrick)
                    {
                        c = (MovableBrick)control;
                    }
                }


                c.BrickMove(MousePosition.X, MousePosition.Y);
                pnl3Map.Refresh();
            }

        }

        /// <summary>
        /// Handles the MouseClick event of the pnlNoTool control.
        /// Allows the user to delete a brick on the area by clicking on the brick to delete
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void pnlNoTool_MouseClick(object sender, MouseEventArgs e)
        {

            disableAllTools();
            deleteBrickToolAction();
        }

        private void txtLevelName_TextChanged(object sender, EventArgs e)
        {

            LevelName = txtLevelName.Text;

        }

        /// <summary>
        /// Handles the MouseClick event of the pnlValidate control.
        /// Allows the user to confirm the level settings and to start playing
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void pnlValidate_MouseClick(object sender, MouseEventArgs e)
        {
            validate();

        }




        private void lblBricks_Click(object sender, EventArgs e)
        {
            disableAllTools();
            addBrickToolAction();
        }

        /// <summary>
        /// Handles the Click event of the lblDelete control.
        /// Allows the user to delete a brick
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lblDelete_Click(object sender, EventArgs e)
        {
            disableAllTools();
            deleteBrickToolAction();
        }

        /// <summary>
        /// Handles the Click event of the lblBonus control.
        /// Allows the user to add bonuses
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lblBonus_Click(object sender, EventArgs e)
        {
            disableAllTools();
            addBonusToolAction();
        }

        /// <summary>
        /// Handles the MouseClick event of the panel3 control.
        /// Allows the user to add bonus on a brick
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            disableAllTools();
            addBonusToolAction();
        }

        /// <summary>
        /// Handles the Click event of the lblValidate control.
        /// Allows the user to confirm the level settings
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lblValidate_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void pnl1Titre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl2Outils_Paint(object sender, PaintEventArgs e)
        {

        }











    }







    public class MovableBrick : Panel
    {
        public LevelCreation ParentForm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MovableBrick"/> class.
        /// </summary>
        /// <param name="f">The f.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public MovableBrick(LevelCreation f, int width, int height)
            : base()
        {
            this.Size = new System.Drawing.Size(width, height);
            ParentForm = f;
        }
        /// <summary>
        /// Move the bricks.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        public void BrickMove(int X, int Y)
        {
            this.SetBounds(X - this.ParentForm.Bounds.X - this.Parent.Bounds.X - this.Width / 2, Y - this.ParentForm.Bounds.Y - this.Parent.Bounds.Y - this.Height, this.Width, this.Height);
        }


        /// <summary>
        /// Déclenche l'événement <see cref="E:System.Windows.Forms.Control.MouseMove" />.
        /// Allows to move a brick
        /// </summary>
        /// <param name="e"><see cref="T:System.Windows.Forms.MouseEventArgs" /> qui contient les données d'événement.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            BrickMove(MousePosition.X, MousePosition.Y);
            this.Parent.Refresh();
        }


        /// <summary>
        /// Déclenche l'événement <see cref="E:System.Windows.Forms.Control.Click" />.
        /// Allows the user to set a brick at a position
        /// </summary>
        /// <param name="e"><see cref="T:System.EventArgs" /> qui contient les données de l'événement.</param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ControlCollection controls = this.Parent.Controls;
            int x = Math.Abs((int)Math.Floor((double)Bounds.X / Width) * Width);
            int y = Math.Abs((int)Math.Floor((double)Bounds.Y / Height) * Height);
            bool canBeAdded = true;
            foreach (Control control in controls)
            {
                if (control.Bounds.X == x && control.Bounds.Y == y)
                {
                    canBeAdded = false;
                }
            }
            if (canBeAdded && ParentForm.NbMaxBricks > 0)
            {
                this.Parent.Controls.Add(new StaticBrick(ParentForm, Width, Height, x, y));
                ParentForm.decNbBricks();
            }
            else if (!canBeAdded)
            {

                ParentForm.ErrorConsole.AppendText("Brique déjà existante.\r\n");

            }
            else if (ParentForm.NbMaxBricks <= 0)
            {
                ParentForm.ErrorConsole.AppendText("Plus de briques disponibles.\r\n");
            }



        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class StaticBrick : Panel
    {
        public LevelCreation ParentForm { get; set; }
        public bool HasBonus { get; set; }
        public AbstractBonus bonus { get; set; }
        public StaticBrick(LevelCreation f, int width, int height, int x, int y)
            : base()
        {
            HasBonus = false;
            this.BackColor = Color.FromArgb(51, 51, 51);
            this.SetBounds(x, y, width, height);
            ParentForm = f;

            this.Refresh();
        }
        /// <summary>
        /// Déclenche l'événement <see cref="E:System.Windows.Forms.Control.Paint" />.
        /// Allows to draw border on a brick to separate each bricks
        /// </summary>
        /// <param name="e"><see cref="T:System.Windows.Forms.PaintEventArgs" /> qui contient les données de l'événement.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.White, ButtonBorderStyle.Solid);

            base.OnPaint(e);
        }
        /// <summary>
        /// Déclenche l'événement <see cref="E:System.Windows.Forms.Control.MouseClick" />.
        /// Allows to confirm the position of a brick or a bonus
        /// </summary>
        /// <param name="e"><see cref="T:System.Windows.Forms.MouseEventArgs" /> qui contient les données de l'événement.</param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (ParentForm.NoToolSelected)
            {
                Parent.Controls.Remove(this);
                ParentForm.incNbBricks();
            }
            else
            {
                if (ParentForm.AddBonusSelected)
                {
                    setBonus(true);
                }

            }
        }

        /// <summary>
        /// Sets the bonus.
        /// </summary>
        /// <param name="bonus">if set to <c>true</c> [bonus].</param>
        public void setBonus(bool bonus)
        {
            if (bonus)
            {
                this.BackColor = Color.FromArgb(80, 150, 1);
                double randomBonus = Math.Floor(new Random().NextDouble() * 3);
                if (randomBonus == 0)
                {
                    this.bonus = new BallSpeedBonus((float)1.4, 15);
                }
                else if (randomBonus == 1)
                {
                    this.bonus = new BarSizeBonus((float)2, 15);
                }
                else if (randomBonus == 2)
                {
                    this.bonus = new AddBallBonus((float)1, 15);
                }
                
                
                HasBonus = true;
            }
            else
            {
                this.BackColor = Color.FromArgb(51, 51, 51);
            }
        }

    }
}
