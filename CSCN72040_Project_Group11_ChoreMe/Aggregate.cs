using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoreMe;

namespace CSCN72040_Project_Group11_ChoreMe
{
    public interface Aggregate<T>
    {
        Iterator<T> createIterator(IteratorType type);
    }
}
