using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class GroupsIterator : Iterator<Users>
    {
        private List<Users> Persons = new List<Users>();
        private int current = 0;
        GroupsIterator(List<Users> persons) => this.Persons = persons;

        public Users getNext()
        {
            return Persons[current++];
        }

        public bool hasNext()
        {
            return current < Persons.Count;
        }
    }
}
