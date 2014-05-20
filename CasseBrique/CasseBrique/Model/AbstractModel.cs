using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Breakout.Events;
using Breakout.Views;

namespace Breakout.Model
{
    public abstract class AbstractModel
    {
        private List<View> views;

        public void AddView(View view)
        {
            views.Add(view);
        }

        public void RemoveView(View view)
        {
            views.Remove(view);
        }

        public void RefreshViews(Event e)
        {
            foreach (View view in views)
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
