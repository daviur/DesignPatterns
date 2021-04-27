using Memento;

namespace MementoClient
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