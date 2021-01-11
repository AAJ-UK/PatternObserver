using ObserverPattern.ObserverInfo;

namespace ObserverPattern.SubjectInfo
{
    interface ISubject
    {
        int Value1 { get; set; }
        int Value2 { get; set; }

        void AddObserver(Observer myObserver);
        void Notify();
        void RemoveObserver(Observer myObserver);
    }
}