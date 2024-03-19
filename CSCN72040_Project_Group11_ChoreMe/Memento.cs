using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class Memento
    {
        private string name;
        private string description;
        private int priority;
        private string category;
        private DateTime dueDate;
        private DateTime creationDate;


        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Priority { get { return priority; } set { priority = value; } }
        public string Category { get { return category; } set { category = value; } }
        public DateTime DueDate { get { return dueDate; } set { dueDate = value; } }
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }

        public Memento(Chore c)
        {
            this.Name = c.Name;
            this.Description = c.Description;
            this.Priority = c.Priority;
            this.Category = c.Category;
            this.DueDate = c.DueDate;
            this.CreationDate = c.CreationDate;
        }

        public Memento(string name, string desc, int prior, string cat, DateTime due, DateTime crtd)
        {
            this.Name = name;
            this.Description = desc;
            this.Priority = prior;
            this.Category = cat;
            this.DueDate = due;
            this.CreationDate = crtd;
        }
    }
}
