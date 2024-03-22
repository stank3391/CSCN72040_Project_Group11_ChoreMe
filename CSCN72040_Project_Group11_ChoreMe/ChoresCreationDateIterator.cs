using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal class ChoresCreationDateIterator : Iterator
    {
        Dictionary<DateTime, Chore> ChoreCreationDate = new Dictionary<DateTime, Chore>();
        public Iterator CreateIterator()
        {
            throw new NotImplementedException();
        }
    }
}
