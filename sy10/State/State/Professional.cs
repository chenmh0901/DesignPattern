using System;
namespace State
{
    public class Professional:IState
    {
        public void Play()
        {
            Console.WriteLine("Play the game at the Professional level.");
        }

        public void DoubleScore()
        {
            Console.WriteLine("Double the score.");
        }

        public void ChangeCards()
        {
            Console.WriteLine("Change cards.");
        }

        public void PeekCards()
        {
            Console.WriteLine("This functionality is not available at this level.");
        }
    }
}
