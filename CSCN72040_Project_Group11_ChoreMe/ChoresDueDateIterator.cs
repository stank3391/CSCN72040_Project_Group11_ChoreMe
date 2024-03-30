using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresDueDateIterator : Iterator<Chore>
    {
        private List<Chore> ChoreDueDate = new List<Chore>();
        private int current = 0;
        
        public ChoresDueDateIterator(List<Chore> chores)
        {
            ChoreDueDate = chores.OrderBy(o => o.DueDate).ToList();
        }
        public Chore Next()
        {
            return ChoreDueDate[++current];
        }

        public bool hasNext()
        {
            return current <= ChoreDueDate.Count -1;
        }
    }
}
