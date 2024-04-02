using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    public class CareTaker
    {
        private List<Memento> savedChores = new List<Memento>();
        public List<Memento> SavedChores { get { return savedChores; } set { savedChores = value; } }
        
        public void AddMemento(Memento m)
        {
            SavedChores.Add(m);
        }
        
        public Memento GetMemento(int index)
        {
            return savedChores.ElementAt(index);
        }

    }
}
