using System;

namespace DesignPatterns.Behavioral.Mediator
{
    internal class Colleague2 : Colleague
    {
        public Colleague2(IMediator mediator) : base(mediator) { }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"{nameof(Colleague2)} received: {message} (from c1)");
        }
    }
}