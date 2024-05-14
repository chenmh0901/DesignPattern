using System;
namespace State
{
    public class Role
    {
        private IState _state;

        public Role(IState state)
        {
            TransitionState(state);
        }

        public void TransitionState(IState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play();
        }

        public void DoubleScore()
        {
            _state.DoubleScore();
        }

        public void ChangeCards()
        {
            _state.ChangeCards();
        }

        public void PeekCards()
        {
            _state.PeekCards();
        }
    }
}
