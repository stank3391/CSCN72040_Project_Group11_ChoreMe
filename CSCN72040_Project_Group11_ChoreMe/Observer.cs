using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal interface Observer
    {
        void update();
        void setSubject(Chore ch);
    }
}
