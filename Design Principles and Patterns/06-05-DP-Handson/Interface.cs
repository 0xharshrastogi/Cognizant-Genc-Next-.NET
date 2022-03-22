namespace MediatorPattern
{
    interface IUser
    {
        public string Name { get; set; }
        void RecieveMessage(string from, string message);
        void SendMessage(string message);

    }

    interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string from, string message);
    }
}

