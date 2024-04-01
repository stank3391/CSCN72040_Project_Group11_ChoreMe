using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    public interface Iterator<T>
    {
        //public Iterator CreateIterator();
        public bool hasNext();
        public T Next();
    }
}
