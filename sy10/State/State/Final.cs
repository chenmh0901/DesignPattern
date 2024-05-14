using System;
namespace State
{
    public class Final:IState
    {
        public void Play()
        {
            Console.WriteLine("Play the game at the Final level.");
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
            Console.WriteLine("Peek at other's cards.");
        }
    }
}
