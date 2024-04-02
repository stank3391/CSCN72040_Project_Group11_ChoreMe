using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCN72040_Project_Group11_ChoreMe
{
    // Subject interface
    public interface IChoreSubject
    {
        void RegisterObserver(IChoreObserver observer);
        void RemoveObserver(IChoreObserver observer);
        void NotifyObservers(string message);
    }
}
