using System.Collections.Generic;
using Breakout.Views;
using Breakout.Events;

namespace Breakout.Model
{
    /// <summary>
    /// Contains all the common operations for models. Here contains the views, and operations to add, remove and refresh them.
    /// </summary>
    public abstract class AbstractModel
    {
        /// <summary>
        /// The views
        /// </summary>
        private List<View> views;

        /// <summary>
        /// Adds the view.
        /// </summary>
        /// <param name="view">The view.</param>
        public void AddView(View view)
        {
            this.views.Add(view);
        }

        /// <summary>
        /// Removes the view.
        /// </summary>
        /// <param name="view">The view.</param>
        public void RemoveView(View view)
        {
            this.views.Remove(view);
        }

        /// <summary>
        /// Refreshes the views.
        /// </summary>
        /// <param name="e">The e.</param>
        public void RefreshViews(Event e)
        {
            foreach (View view in this.views)
            {
                view.Refresh(e);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractModel"/> class.
        /// </summary>
        public AbstractModel()
        {
            this.views = new List<View>();
        }
    }
}
