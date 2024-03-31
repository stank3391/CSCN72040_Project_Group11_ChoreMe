using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresPriorityIterator : Iterator<Chore>
    {
        public Dictionary<int, List<Chore>> ChorePriority;
        private int current = 1;        //Priority is 1-4
        private int currentChore = 0;

        public ChoresPriorityIterator(List<Chore> list)
        {
            ChorePriority = new Dictionary<int, List<Chore>>();
            ChorePriority.Add(1,  new List<Chore>());
            ChorePriority.Add(2, new List<Chore>());
            ChorePriority.Add(3, new List<Chore>());
            ChorePriority.Add(4, new List<Chore>());
            foreach (Chore chore in list)
            {
                ChorePriority[chore.Priority].Add(chore);
            }
        }

        public Chore Next()
        {
            if (currentChore > ChorePriority[current].Count -1) {
                if (current < 4)
                {
                    current++;
                    currentChore = 0;
                    return Next();
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
            if (currentChore > ChorePriority[current].Count - 1)
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
