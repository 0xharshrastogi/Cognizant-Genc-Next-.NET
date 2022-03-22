namespace MediatorPattern
{

    class BasicUser : IUser
    {
        private ChatMediators chat;
        public string Name { get; set; }

        public BasicUser(string name, ChatMediators chat)
        {
            this.chat = chat;
            this.Name = name;

            this.chat.AddUser(this);
        }


        public void RecieveMessage(string from, string message)
        {
            Console.WriteLine($"Recieved Message From {from}: {message}");
        }

        public void SendMessage(string message)
        {
            chat.SendMessage(this.Name, message);
        }
    }

    class PremiumUser : IUser
    {
        private ChatMediators chat;
        public string Name { get; set; }

        public PremiumUser(string name, ChatMediators chat)
        {
            this.Name = name;
            this.chat = chat;

            this.chat.AddUser(this);
        }
        public void RecieveMessage(string from, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Recieved Message From {from}: {message}");
            Console.ResetColor();
        }

        public void SendMessage(string message)
        {
            chat.SendMessage(this.Name, message);
        }
    }
}

