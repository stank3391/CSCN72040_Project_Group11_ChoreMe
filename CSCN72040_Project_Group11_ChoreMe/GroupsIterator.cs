using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class GroupsIterator : Iterator<User>
    {
        private List<User> Persons = new List<User>();
        private int current = 0;
        GroupsIterator(List<User> persons) => this.Persons = persons;

        public User Next()
        {
            return Persons[current++];
        }

        public bool hasNext()
        {
            return current < Persons.Count;
        }
    }
}
