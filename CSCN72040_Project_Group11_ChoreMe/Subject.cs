﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreMe
{
    internal interface Subject
    {
        void registerObserver(Observer ob);
        void removeObserver(Observer ob);
        void notifyObserver();
    }
}
