using System;
namespace State
{
    public class Secondary:IState
    {
        public void Play()
        {
            Console.WriteLine("Play the game at Secondary level.");
        }

        public void DoubleScore()
        {
            Console.WriteLine("Double the score.");
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
