using System;
using System.Collections.Generic;
using ObserverPattern.ObserverInfo;
using ObserverPattern.SubjectInfo;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a signle subject. In this example we will be able to change values 1 and 2
            Subject subject = new Subject();

            // create 5 new observers of the subject and give each a name. the name is just for clarity.
            Observer OBS1 = new Observer();
            Observer OBS2 = new Observer();
            Observer OBS3 = new Observer();
            Observer OBS4 = new Observer();
            Observer OBS5 = new Observer();

            OBS1.MObserverName = "Observer 1";
            OBS2.MObserverName = "Observer 2";
            OBS3.MObserverName = "Observer 3";
            OBS4.MObserverName = "Observer 4";
            OBS5.MObserverName = "Observer 5";
                
            // add all 5 into the subject, so if it has a change of value all Observers are notified         

            subject.AddObserver(OBS1);
            subject.AddObserver(OBS2);
            subject.AddObserver(OBS3);
            subject.AddObserver(OBS4);
            subject.AddObserver(OBS5);

            // change the subjects values. The console window shows all 5 being updated
            subject.Value1 = 1;
            subject.Value2 = 2;

            // remove Observers 3 and 4 from the list
            subject.RemoveObserver(OBS3);
            subject.RemoveObserver(OBS4);

            // change the subjects values again. The console window shows the remaining observers being updated
            subject.Value1 = 3;
            subject.Value2 = 4;
        }
    }
}
