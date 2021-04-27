using System;

namespace Mediator
{
    internal class Colleague1 : Colleague
    {
        public Colleague1(IMediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{nameof(Colleague1)} received: {message} (from c2)");
        }
    }
}