using System;
using System.Collections.Generic;
namespace Observer
{
    public class Cat : ISubject
    {
        private List<IObserver> _Observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _Observers)
            {
                observer.Update();
            }
        }

        //猫开始叫
        public void Yell()
        {
            Console.WriteLine("Cat: 高声叫...");
            Notify();
        }
    }
}
