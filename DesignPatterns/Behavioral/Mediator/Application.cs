namespace DesignPatterns.Behavioral.Mediator
{
    public class Application
    {
        public void Run()
        {
            var mediator = new ConcreteMediator();
            var c1 = new Colleague1(mediator);
            var c2 = new Colleague2(mediator);

            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            //mediator.Register(c1);
            //mediator.Register(c2);

            //var c1 = mediator.CreateCollegue<Colleague1>();
            //var c2 = mediator.CreateCollegue<Colleague2>();

            c1.Send("Hello c2!");
            c2.Send("Hello c1!");
        }
    }
}