namespace ObserverPattern
{
    public class Message
    {
        private readonly string textMessage;
        public string TextMessage => textMessage;

        public Message(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException("message", "It should be string of at least 1 char");

            this.textMessage = message;
        }

    }
}