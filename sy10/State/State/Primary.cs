using System;
namespace State
{
    public class Primary:IState
    {
        public void Play()
        {
            Console.WriteLine("Play the game at Primary level.");
        }

        public void DoubleScore()
        {
            Console.WriteLine("This functionality is not available at this level.");
        }

        public void ChangeCards()
        {
            Console.WriteLine("This functionality is not available at this level.");
        }

        public void PeekCards()
        {
            Console.WriteLine("This functionality is not available at this level.");
        }
    }
}
