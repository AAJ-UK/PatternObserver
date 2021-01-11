using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverInfo
{
    class Observer : IObserver
    {
        // Just for info, give each observer a name. This helps us see how the pattern works but isn't actually required.

        public string MObserverName { get; set; }
        // If this instance of the class is on the list of Observers in the Subject
        // then this Update method will be triggered on any new value change within the Subject Object.
        public void Update(List<int> Prices)
        {
            foreach (int p in Prices)
            {
                Console.WriteLine("{0} received updated Value : {1}", MObserverName, p.ToString()); ;
            }

        }
    }
}
