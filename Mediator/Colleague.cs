namespace Mediator
{
    public abstract class Colleague
    {
        public Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }

        internal IMediator Mediator { get; }

        public virtual void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}