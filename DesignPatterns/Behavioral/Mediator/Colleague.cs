namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Colleague
    {
        internal IMediator Mediator { get; }

        public Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }

        public virtual void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}