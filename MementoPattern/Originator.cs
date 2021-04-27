using System;

namespace Memento
{
    public class Originator
    {
        private int _state;

        public Memento GetState()
        {
            Console.WriteLine($"Getting Originator State: {_state}");
            return new Memento() {State = _state};
        }

        public void RestoreState(Memento memento)
        {
            var previous = _state;
            _state = memento.State;
            Console.WriteLine($"Restoring Originator State: {previous}->{_state}");
        }

        public void Operate()
        {
            _state++;
        }
    }
}