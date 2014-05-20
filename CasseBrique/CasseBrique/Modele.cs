
using System.Collections.Generic;
namespace CasseBrique
{
    public abstract class Modele
    {
        private List<View> views;

        public List<View> Views
        {
            get { return views; }
            set { views = value; }
        }

        public Modele()
        {
            this.views = new List<View>();        
        }

        public void addView(View view)
        {
            this.views.Add(view);
        }
    }
}
