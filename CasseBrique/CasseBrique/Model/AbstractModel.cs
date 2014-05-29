using System.Collections.Generic;
using Breakout.Views;
using Breakout.Events;

namespace Breakout.Model
{
    public abstract class AbstractModel
    {
        private List<View> views;

        public void AddView(View view)
        {
            this.views.Add(view);
        }

        public void RemoveView(View view)
        {
            this.views.Remove(view);
        }

        public void RefreshViews(Event e)
        {
            foreach (View view in this.views)
            {
                view.Refresh(e);
            }
        }

        public AbstractModel()
        {
            this.views = new List<View>();
        }
    }
}
