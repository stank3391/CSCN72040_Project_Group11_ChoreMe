using CSCN72040_Project_Group11_ChoreMe;
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
    
    public class User : Aggregate<Chore>
    {
        public string name { get; set; }
        public List<Chore> chores = new List<Chore>();

        public User(string name) {
            this.name = name;
            this.chores = new List<Chore>();
        }

        public User (string name, List<Chore> chores) 
        {
            this.name = name;
            this.chores = chores;
        }
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

        public void removeChore(Chore chore)
        {
            chores.Remove(chore);   
        }
    }
}
