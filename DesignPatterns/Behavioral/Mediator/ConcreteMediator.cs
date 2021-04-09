using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Mediator
{
    internal class ConcreteMediator : IMediator
    {
        internal Colleague1 Colleague1 { get; set; }

        internal Colleague2 Colleague2 { get; set; }

        private readonly IList<Colleague> _colleagues = new List<Colleague>();

        //public void Register(Colleague colleague)
        //{
        //    colleague.Mediator = this;
        //    _colleagues.Add(colleague);
        //}

        //public T CreateCollegue<T>() where T : Colleague, new()
        //{
        //    var c = new T {Mediator = this};
        //    _colleagues.Add(c);
        //    return c;
        //}

        public void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.HandleNotification(message);
            }
            else
            {
                Colleague1.HandleNotification(message);
            }

            //_colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}