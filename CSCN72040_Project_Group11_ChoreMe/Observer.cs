using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCN72040_Project_Group11_ChoreMe
{
    // Observer interface
    public interface IChoreObserver
    {
        void NotifyChoreCreated(string message);
    }
}
