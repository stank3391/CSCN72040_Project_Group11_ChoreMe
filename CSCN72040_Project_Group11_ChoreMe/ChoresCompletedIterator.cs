using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresCompletedIterator : Iterator<Chore>
    {
        private List<Chore> ChoreCompleted = new List<Chore>();
        private int current = 0;

        public ChoresCompletedIterator(List<Chore> chores)
        {
            foreach (Chore chore in chores)
            {
                if (chore.IsComplete)
                {
                    ChoreCompleted.Add(chore);
                }
            }
        }
        public Chore Next()
        {
            return ChoreCompleted[current++];
        }
        public void Dispose()
        {
            ChoreCompleted.Clear();
        }
        public bool hasNext()
        {
            return current <= ChoreCompleted.Count - 1;
        }
    }
}
