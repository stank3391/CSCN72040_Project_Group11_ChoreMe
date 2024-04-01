using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    public class Chore
    {
        private string name;
        private string description;
        private int priority;
        private string category;
        private DateTime dueDate;
        private DateTime creationDate;


        public string Name { get { return name; } set { name = value; }}
        public string Description { get { return description; } set { description = value; } }
        public int Priority { get { return priority; } set { priority = value; } }
        public string Category { get { return category; } set { category = value; } }
        public DateTime DueDate { get { return dueDate; } set { dueDate = value; } }
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }

        public Chore(string name, string desc, int prior, string cat, DateTime due)
        {
            this.Name = name;
            this.Description = desc;
            this.Priority = prior;
            this.Category = cat;
            this.DueDate = due;
            this.CreationDate = DateTime.Now;
        }

        public Chore(Memento m)
        {
            this.Name = m.Name;
            this.Description = m.Description;
            this.Priority = m.Priority;
            this.Category = m.Category;
            this.DueDate = m.DueDate;
            this.CreationDate = m.CreationDate;
        }

        public Memento StoreInMemento()
        {
            return new Memento(this);
        }

        public Chore RestoreFromMemento(Memento m)
        {
            return new Chore(m);
        }
    }
}
