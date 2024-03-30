using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    public enum IteratorType {
        priority,
        category,
        duedate,
        creationdate
    }
    
    internal class Users
    {
        public string name { get; set; }
        public List<Chore> chores = new List<Chore>();

        public void addChore(Chore chore)
        {
            chores.Add(chore);
        }

        public Iterator<Chore> createIterator(IteratorType type) {
            switch (type)
            {
                case IteratorType.priority:
                    return new ChoresPriorityIterator(chores);
                case IteratorType.category:
                    return new ChoresCategoryIterator(chores);
                case IteratorType.duedate:
                    return new ChoresDueDateIterator(chores);
                case IteratorType.creationdate:
                    return new ChoresCreationDateIterator(chores);
                default:
                    return null;
            }
        }
    }
}
