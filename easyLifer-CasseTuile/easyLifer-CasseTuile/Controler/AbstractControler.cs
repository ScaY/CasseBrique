using Breakout.Model;


namespace Breakout.Controler
{
    /// <summary>
    /// This is a class that represents an abstract controler.
    /// </summary>
    public abstract class AbstractControler
    {
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public BreakoutModel Model { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractControler"/> class.
        /// </summary>
        public AbstractControler()
        {
            this.Model = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractControler"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public AbstractControler(BreakoutModel model)
        {
            this.Model = model;
        }
    }
}
