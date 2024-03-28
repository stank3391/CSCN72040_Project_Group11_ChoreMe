using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    interface Iterator<T>
    {
        //public Iterator CreateIterator();
        public bool hasNext();
        public T getNext();
    }
}
