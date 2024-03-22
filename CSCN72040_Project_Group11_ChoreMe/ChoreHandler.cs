using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoreHandler : Subject
    {
        private Chore chore;
        
        public List<Observer> Observers = new List<Observer>();
        
        public Chore Chore { get { return chore; } set { chore = value; } }


        public void notifyObserver()
        {
            for (int i = 0; i <  Observers.Count; i++)
            {
                Observers.ElementAt(i).update();
            }
        }
        public void registerObserver(Observer ob)
        {
            if (ob != null)
            {
                Observers.Add(ob);
            }
        }
        public void removeObserver(Observer ob)
        {
            if (ob != null && Observers.Count != 0)
            {
                Observers.Remove(ob);
            }
        }
    }
}
