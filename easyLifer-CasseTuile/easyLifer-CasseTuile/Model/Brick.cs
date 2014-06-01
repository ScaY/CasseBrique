using Microsoft.Xna.Framework;
using Breakout.Bonus;

namespace Breakout.Model
{
    /// <summary>
    /// This is a class that represents a brick.
    /// </summary>
    public class Brick : Shape
    {
        /// <summary>
        /// Gets or sets the life.
        /// </summary>
        /// <value>
        /// The life.
        /// </value>
        public int Life { get; set; }

        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>
        /// <value>
        /// The x brick.
        /// </value>
        public int XBrick { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate.
        /// </summary>
        /// <value>
        /// The y brick.
        /// </value>
        public int YBrick { get; set; }


        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        public virtual AbstractBonus Bonus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Brick"/> class.
        /// </summary>
        public Brick()
        {
            this.XBrick = 0;
            this.YBrick = 0;
            this.Life = 0;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Brick"/> class.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="life">The life.</param>
        /// <param name="size">The size.</param>
        public Brick(Vector2 position, int life, Size size) : base(position, Vector2.Zero, 0f, size)
        {
            this.XBrick = 0;
            this.YBrick = 0;
            this.Life = life;
        }

        /// <summary>
        /// Gets the b box.
        /// </summary>
        /// <returns></returns>
        public Rectangle GetBBox()
        {
            return new Rectangle((int)this.Position.X, (int)this.Position.Y, (int)this.Size.Width, (int)this.Size.Height);
        }

        /// <summary>
        /// Handles the trajectory.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height frame.</param>
        /// <param name="widthFrame">The width frame.</param>
        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if(obj == this){
                return true;
            }

            if (obj is Brick)
            {
                Brick other = (Brick)obj;
                return other.XBrick == this.XBrick && other.YBrick == this.YBrick;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}{1}", this.XBrick, this.YBrick);
        }
    }

    



}