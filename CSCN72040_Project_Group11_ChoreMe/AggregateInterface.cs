using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCN72040_Project_Group11_ChoreMe
{
    interface AggregateInterface<T>
    {
        IteratorInterface<T> createIterator();
    }
}
