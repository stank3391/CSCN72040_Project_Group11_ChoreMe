using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresPriorityIterator : Iterator<Chore>
    {  
        private Dictionary<int, List<Chore>> ChorePriority = new Dictionary<int, List<Chore>>();
        private int current = 1;        //Priority is 1-4
        private int currentChore = 0;

        public Chore getNext()
        {
            if (currentChore > ChorePriority[current].Count) {
                if (current < 4)
                {
                    current++;
                    currentChore = 0;
                    return getNext();
                }
                else
                {
                    return null;    //OUT OF BOUNDS. Should never reach this.
                }
            }
            else
            {
                return ChorePriority[current][currentChore++];
            }
        }
        public bool hasNext()
        {
            if (currentChore > ChorePriority[current].Count)
            {
                if (current < 4)
                {
                    current++;
                    currentChore = 0;
                    return hasNext();
                }
                else
                {
                    return false;    //OUT OF BOUNDS
                }
            }
            else
            {
                return true;
            }
        }
    }
}
