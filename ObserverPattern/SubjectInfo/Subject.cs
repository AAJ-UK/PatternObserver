
using ObserverPattern.ObserverInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.SubjectInfo
{
    /// <summary>
    /// The subject classes monitors the world and informs onjects when changes occur.
    /// </summary>
    class Subject : ISubject
    {
        // create a blank list of observors
        List<IObserver> mObservers = new List<IObserver>();

        // create a couple of values to represent real world values.
        private int M_realWorldValue1 = 0;
        private int M_realWorldValue2 = 0;

        // check for the real worl values being updated.
        // If they change, call the Notify Method.
        public int Value1
        {
            get { return M_realWorldValue1; }
            set
            {
                M_realWorldValue1 = value;
                Console.WriteLine("Subject Value 1 updated to " + M_realWorldValue1.ToString());
                Notify();
            }
        }
        public int Value2
        {
            get { return M_realWorldValue2; }
            set
            {
                M_realWorldValue2 = value;
                Console.WriteLine("Subject Value 2 updated to " + M_realWorldValue2.ToString());
                Notify();
            }
        }

        
        public void AddObserver(Observer myObserver)
        {
            // Add an observer to the list we need to notify if things change
            mObservers.Add(myObserver);
            Console.WriteLine("Added Observer :" + myObserver.MObserverName);
        }

        public void RemoveObserver(Observer myObserver)
        {
            // remove an observor from the list of observers we need to notify of change.
            int idx = mObservers.IndexOf(myObserver);
            mObservers.RemoveAt(idx);
            Console.WriteLine("Removed Observer :"+ myObserver.MObserverName);
        }

        public void Notify()
        {
            // when we have to notify the Observer classes of change, run through each
            // observor on our list and trigger its update method, passing in the new data for it to process.
            
            // generate the list of prices
            List<int> M_Prices = new List<int>();
            M_Prices.Add(M_realWorldValue1);
            M_Prices.Add(M_realWorldValue2);

            // Send the new data to the observers.
            foreach (IObserver O in mObservers)
            {
                O.Update(M_Prices);
            }
        }

    }

}
