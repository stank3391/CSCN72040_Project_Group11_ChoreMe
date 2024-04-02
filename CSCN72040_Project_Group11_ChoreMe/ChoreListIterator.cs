using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoreMe;

namespace ChoreMe
{
    internal class ChoreListIterator : Iterator<Chore>
    {
        private List<Chore> list;
        int current = 0;
        ChoreListIterator (List<Chore> list)
        {
            this.list = list;
        }

        public bool hasNext()
        {
            return current < list.Count;
        }

        public Chore Next()
        {
            return list[current++];
        }
    }
}
