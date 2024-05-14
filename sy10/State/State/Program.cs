using System;
namespace State
{
    public class Program
    {
        static void Main(string[] args)
        {
            Role role;

            role = new Role(new Primary());
            role.Play();

            role.TransitionState(new Secondary());
            role.DoubleScore();

            role.TransitionState(new Professional());
            role.ChangeCards();

            role.TransitionState(new Final());
            role.PeekCards();

            Console.ReadKey();
        }
    }
}
