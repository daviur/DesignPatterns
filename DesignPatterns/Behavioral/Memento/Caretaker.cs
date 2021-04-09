using System;
using System.Collections.Generic;
using MementoPattern;

namespace DesignPatterns.Behavioral.Memento
{
    public class Caretaker
    {
        private readonly Originator _originator;
        private readonly Stack<MementoPattern.Memento> _redoMementoes = new();
        private readonly Stack<MementoPattern.Memento> _undoMementoes = new();

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Save()
        {
            _undoMementoes.Push(_originator.GetState());
        }

        public void Undo()
        {
            if (_undoMementoes.Count <= 0)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            _redoMementoes.Push(_originator.GetState());
            _originator.RestoreState(_undoMementoes.Pop());
        }

        public void Redo()
        {
            if (_redoMementoes.Count <= 0)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }

            _undoMementoes.Push(_originator.GetState());
            _originator.RestoreState(_redoMementoes.Pop());
        }
    }
}