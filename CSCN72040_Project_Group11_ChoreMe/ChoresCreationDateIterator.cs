using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresCreationDateIterator : Iterator<Chore>
    {
        private List<Chore> ChoreCreationDate = new List<Chore>();
        private int current = 0;

        public ChoresCreationDateIterator(List<Chore> chores)
        {
            ChoreCreationDate = chores.OrderBy(o => o.DueDate).ToList();
        }
        public Chore Next()
        {
            return ChoreCreationDate[current++];
        }

        public bool hasNext()
        {
            return current <= ChoreCreationDate.Count - 1;
        }
    }
}
