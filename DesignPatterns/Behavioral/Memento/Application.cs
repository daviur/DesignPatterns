using System.ComponentModel;
using MementoPattern;

namespace DesignPatterns.Behavioral.Memento
{
    public class Application
    {
        public void Run()
        {
            var o = new Originator();
            var ct = new Caretaker(o);

            ct.Save();
            o.Operate();

            ct.Save();
            o.Operate();

            ct.Save();
            o.Operate();
            
            ct.Save();
            o.Operate();

            ct.Undo();
            ct.Undo();
            ct.Undo();
            ct.Undo();
            ct.Undo();

            ct.Redo();
            ct.Redo();
            ct.Redo();
            ct.Redo();
            ct.Redo();
        }
    }
}