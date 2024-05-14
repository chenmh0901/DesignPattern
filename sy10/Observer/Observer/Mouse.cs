using System;
namespace Observer
{
    public class Mouse : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Mouse: 快速逃跑...");
        }
    }
}
