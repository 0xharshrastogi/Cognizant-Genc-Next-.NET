namespace ObserverPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            var suscriber1 = new MessageSuscriber();
            var suscriber2 = new MessageSuscriber();

            var publisher = new MessagePublisher();

            publisher.Attach(suscriber1);
            publisher.Attach(suscriber2);

            publisher.Notify(new Message("Hello, Mia"));

            publisher.Detach(suscriber1);
            publisher.Notify(new Message("Suscriber Disconnected"));

            publisher.UpdateState("InActive");
        }
    }

}