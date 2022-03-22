namespace ObserverPattern
{
    class MessageSuscriber : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine($"Message: {m.TextMessage}");
        }
    }

}