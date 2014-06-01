using Breakout.Model;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents the view of a bar.
    /// </summary>
    public class ViewBar : ShapeView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBar"/> class.
        /// </summary>
        /// <param name="bar">The bar.</param>
        public ViewBar(Bar bar) : base(bar)
        {
        }
    }
}
