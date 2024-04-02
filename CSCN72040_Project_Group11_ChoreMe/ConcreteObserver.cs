using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCN72040_Project_Group11_ChoreMe
{
    // Concrete observer
    public class AlertBoxObserver : IChoreObserver
    {
        public void NotifyChoreCreated(string message)
        {
            MessageBox.Show(message, "Chore Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
