using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresIncompletedIterator : Iterator<Chore>
    {
        private List<Chore> ChoreIncompleted = new List<Chore>();
        private int current = 0;

        public ChoresIncompletedIterator(List<Chore> chores)
        {
            foreach (Chore chore in chores)
            {
                if (!chore.IsComplete)
                {
                    ChoreIncompleted.Add(chore);
                }
            }
        }
        public Chore Next()
        {
            return ChoreIncompleted[current++];
        }
        public void Dispose()
        {
            ChoreIncompleted.Clear();
        }
        public bool hasNext()
        {
            return current <= ChoreIncompleted.Count - 1;
        }
    }
}
