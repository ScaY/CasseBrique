using Breakout.Model;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents the view of a ball.
    /// </summary>
    public class ViewBall : ShapeView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBall"/> class.
        /// </summary>
        /// <param name="ball">The ball.</param>
        public ViewBall(Ball ball) : base(ball)
        {  
        }
    }

}
