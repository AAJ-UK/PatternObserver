using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverInfo
{
    interface IObserver
    {
        void Update(List<int> Prices);
    }
}
