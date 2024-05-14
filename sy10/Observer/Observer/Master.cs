using System;
namespace Observer
{
    public class Master : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Master: 被惊醒...");
        }
    }
}
