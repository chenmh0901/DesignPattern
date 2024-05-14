using System;
namespace State
{
    public interface IState
    {
        void Play();
        void DoubleScore();
        void ChangeCards();
        void PeekCards();
    }
}
